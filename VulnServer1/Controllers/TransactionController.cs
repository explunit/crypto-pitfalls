using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using Utils;

namespace VulnServer1.Controllers
{
	public struct TransactionResult
	{
		public string Status;
		public long ConfirmationNumber;
	}

	public class TransactionController : ApiController
	{
		public TransactionResult Get( string ticket )
		{
			var encryptionKeyString = "4f256766a4075027695bd48b444e1ac5c7c17385a1b4f1779e6385da24d97997";
			byte[] encryptionKey = QuickCrypto.StringToByteArray( encryptionKeyString );

			//var testValue = "15608714654|ACPT|109.76|20150203 23:59";

			//var testToken = "cc50cf4e7de93ba5e9b15993b0fc1798208d3c91e0c4c73c1b183e8d1fee07e862c6eae43a91d6c7982163dbfc6df64fe322c63a73f7dfdcbe64992ba826dff5a4ccbb57fcc4e701db12016a17b18874";

			//byte[] IV = QuickCrypto.GetRandomIV();
			//byte[] encrypted = QuickCrypto.EncryptStringToBytes_Aes( testValue, encryptionKey, IV );

			//string ivHex = QuickCrypto.ByteArrayToString( IV );
			//string tokenHex = QuickCrypto.ByteArrayToString( encrypted );

			byte[] ticketBytes = QuickCrypto.StringToByteArray( ticket.Substring( 32 ) );
			byte[] ivBytes = QuickCrypto.StringToByteArray( ticket.Substring( 0, 32 ) );
			string decrypted = QuickCrypto.DecryptStringFromBytes_Aes( ticketBytes, encryptionKey, ivBytes );

			if ( decrypted.Split( '|' ).Length == 4 )
			{
				return new TransactionResult() { Status = "OK", ConfirmationNumber = 123 };
			}
			return new TransactionResult() { Status = "Invalid Request" };
		}
	}
}