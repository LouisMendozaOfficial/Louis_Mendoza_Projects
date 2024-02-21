using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDecryptionDLL
{
    public class EncryptionDecryptionService
    {
		private static char Cipher(char character, int key)
		{

			if (!char.IsLetter(character))
				return character;

			char offset = char.IsUpper(character) ? 'A' : 'a';
			return (char)((((character + key) - offset) % 26) + offset);
		}

		public static string Encrypt(string inputString, int key)
		{
			string output = string.Empty;

			foreach (char character in inputString)
				output += Cipher(character, key);

			return output;
		}

		public static string Decrypt(string inputString, int key)
		{
			return Encrypt(inputString, 26 - key);
		}
	}
}
