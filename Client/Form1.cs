using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Utils;

namespace Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			encryptionKey = QuickCrypto.StringToByteArray( this.encryptionKeyString );
		}
		private string encryptionKeyString = "4f256766a4075027695bd48b444e1ac5c7c17385a1b4f1779e6385da24d97997";
		private byte[] encryptionKey;

		private void btnGenerate_Click( object sender, EventArgs e )
		{
			var expiration = DateTime.UtcNow.AddMinutes( 30 ).ToString( "yyyy-MM-dd HH:mm:ss" );
			txtPlainToken.Text = txtAccountNumber.Text
				+ "|" + txtReasonCode.Text
				+ "|" + txtAmount.Text
				+ "|" + expiration;

			//TODO: need some crypto

			setBlockLabels();
		}

		private void setBlockLabels()
		{
			txtDecrypted.Text = null;
			txtException.Text = null;
			txtBlockLabelsEnc.Text = null;
			for ( int x = 1; x <= txtEncryptedToken.Text.Length / 32; x++ )
			{
				txtBlockLabelsEnc.Text += "Block " + x.ToString() + "                         ";
			}
			txtBlockLabelsPln.Text = null;
			for ( int x = 1; x <= txtPlainToken.Text.Length / 16 + 1; x++ )
			{
				txtBlockLabelsPln.Text += "Block " + x.ToString() + "         ";
			}
		}

		private void btnDecrypt_Click( object sender, EventArgs e )
		{
			txtException.Text = null;
			txtDecrypted.Text = null;
			try
			{
				byte[] cipherText = QuickCrypto.StringToByteArray( txtEncryptedToken.Text.Substring( 32 ) );
				byte[] ivBytes = QuickCrypto.StringToByteArray( txtEncryptedToken.Text.Substring( 0, 32 ) );

				string plaintext = null;

				using ( Aes aesAlg = Aes.Create() )
				{
					aesAlg.Key = encryptionKey;
					aesAlg.IV = ivBytes;
					aesAlg.Padding = PaddingMode.None;

					ICryptoTransform decryptor = aesAlg.CreateDecryptor( aesAlg.Key, aesAlg.IV );

					using ( MemoryStream msDecrypt = new MemoryStream( cipherText ) )
					using ( CryptoStream csDecrypt = new CryptoStream( msDecrypt, decryptor, CryptoStreamMode.Read ) )
					using ( StreamReader srDecrypt = new StreamReader( csDecrypt ) )
					{

						plaintext = srDecrypt.ReadToEnd();
					}
				}

				for(int i = 0; i < plaintext.Length; i++) {
					char c = plaintext[ i ];
					if ( (int)c < 32 || (int)c > 126 )
					{
						txtDecrypted.Text += @"\" + (int)c;
					}
					else
					{
						txtDecrypted.Text += c;
					}
				}
			}
			catch ( Exception ex )
			{
				txtException.Text = ex.ToString();
			}
		}
	}



































}
