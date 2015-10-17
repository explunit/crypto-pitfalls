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
			if ( String.IsNullOrEmpty( ticket ) ) return new TransactionResult();
			var encryptionKeyString = "4f256766a4075027695bd48b444e1ac5c7c17385a1b4f1779e6385da24d97997";
			byte[] encryptionKey = QuickCrypto.StringToByteArray( encryptionKeyString );

			byte[] ticketBytes = QuickCrypto.StringToByteArray( ticket.Substring( 32 ) );
			byte[] ivBytes = QuickCrypto.StringToByteArray( ticket.Substring( 0, 32 ) );
			string decrypted;
			try
			{
				decrypted = QuickCrypto.DecryptStringFromBytes_Aes( 
					ticketBytes, encryptionKey, ivBytes );
			}
			catch
			{
				return new TransactionResult() { Status = "Bad Token" };
			}

			long accountNumber = 0;
			string[] ticketParts = decrypted.Split( '|' );
			// some fake validation
			bool validAccount = Int64.TryParse( ticketParts[ 0 ], out accountNumber );
			if ( ticketParts.Length == 4 && validAccount )
			{
				return new TransactionResult() { Status = "OK", ConfirmationNumber = 123 };
			}
			return new TransactionResult() { Status = "Invalid Request" };
		}
	}
}