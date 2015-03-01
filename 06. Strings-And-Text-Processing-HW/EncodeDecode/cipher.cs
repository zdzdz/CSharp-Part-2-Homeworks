//Problem 7. Encode/decode

//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class cipher
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            Console.Write("Enter a KEY (sequence of random characters without spaces): ");
            string key = Console.ReadLine();
            Console.WriteLine("\nEncryption: {0}", Encrypt(word, key));
            Console.WriteLine("\nEncryption + decryption: {0}\n", Decrypt(Encrypt(word, key), key));
        }
        static string Encrypt(string word, string key)
        {
            StringBuilder cipher = new StringBuilder();
            int inputLetter;
            int keyLetter;
            for (int i = 0; i < word.Length; i++)
            {
                inputLetter = (int)word[i];
                keyLetter = (int)key[i % key.Length];
                cipher.Append((char)(inputLetter ^ keyLetter));
            }
            return cipher.ToString();
        }
        static string Decrypt(string word, string key)
        {
            return Encrypt(word, key);
        }
    }
}
