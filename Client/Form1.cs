using System;
using System.Windows.Forms;
using Utils;

namespace Client
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click( object sender, EventArgs e )
		{
			var encryptionKeyString = "4f256766a4075027695bd48b444e1ac5c7c17385a1b4f1779e6385da24d97997";
			byte[] encryptionKey = QuickCrypto.StringToByteArray( encryptionKeyString );

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
	}



































}
