using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptoquip
{
    public class Encrypt
    {
        public static string EncryptMessage(string message, List<char> key)
        {
           message = message.ToLower();
           List<char> alphabet = new List<char> { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
           char[] encryptedMessage = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                int index = alphabet.IndexOf(message[i]);
                encryptedMessage[i] = key[index];
            }

            return new string(encryptedMessage);
        }
    }
}
