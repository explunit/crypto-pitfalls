using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
	public static class QuickCrypto
	{
        //public static string DecryptStringFromBytes_Aes( byte[] cipherText, byte[] Key, byte[] IV )
        //TODO: need some crypto
        // from here https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=netframework-4.8.1


























        // http://stackoverflow.com/a/311179/151212
        public static string ByteArrayToString( byte[] ba )
		{
			StringBuilder hex = new StringBuilder( ba.Length * 2 );
			foreach ( byte b in ba )
			{
				hex.AppendFormat( "{0:x2}", b );
			}
			return hex.ToString();
		}

		// http://stackoverflow.com/a/311179/151212
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

		public static byte[] GetRandomIV()
		{
			var key = new byte[ 16 ];
			RandomNumberGenerator.Create().GetBytes( key );
			return key;
		}
	}
}
