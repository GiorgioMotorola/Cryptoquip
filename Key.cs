using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptoquip
{
    public class Key
    {
        public static List<char> GenerateKey(List<char> alphabet)
        {

            Random random = new Random();
            List<char> key = new List<char>(alphabet);

            // Shuffle the key
            for (int i = 0; i < key.Count; i++)
            {
                int j = random.Next(i, key.Count);
                char temp = key[i];
                key[i] = key[j];
                key[j] = temp;
            }

            return key;
        }
    }
}
