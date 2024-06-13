using System.Text;

namespace CesarCipher
{
    public class Cipher
    {
        public static string Encrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character + shift - baseASCII) % 26) + baseASCII));
                }
                else if (char.IsDigit(character))
                {
                    result.Append((char)(((character - '0' + shift) % 10) + '0'));
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character - shift - baseASCII + 26) % 26) + baseASCII));
                }
                else if (char.IsDigit(character))
                {
                    result.Append((char)(((character - '0' - shift + 10) % 10) + '0'));
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }
    }
}
