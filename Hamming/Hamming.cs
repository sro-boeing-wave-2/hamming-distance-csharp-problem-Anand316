using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            int i = 0;

            if (original == null)
               throw new ArgumentNullException("original");
            else if (current == null)
               throw new ArgumentNullException("current");
            else if (original.Length != current.Length)
               throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            else
            {
                 foreach(char c in original)
                {
                    if (c != current[i])
                        hammingDistance += 1;
                    i++;
                }
            }
            return hammingDistance;
        }
    }
}
