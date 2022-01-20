using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_hashtable_easy
{
    public class Pangram
    {
        /// <summary>
        /// A pangram is a sentence where every letter of the English alphabet appears at least once.
        /// Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
        /// </summary>
        /// <param name="sentence">single string sentence with spaces and punctuation</param>
        /// <returns>true if every letter in alphabet is found at least once in sentence</returns>
        public bool CheckIfPangram(string sentence)
        {
            Dictionary<char, int> alphabetUsed = createAlphabetic();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (alphabetUsed.ContainsKey(sentence[i]))
                {
                    alphabetUsed[sentence[i]] = 1;
                }
            }
            if (alphabetUsed.ContainsValue(0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Dictionary<char, int> createAlphabetic()
        {
            Dictionary<char, int> alphabetUsed = new Dictionary<char, int>()
            {
                {'a',0},
                {'b',0},
                {'c',0},
                {'d',0},
                {'e',0},
                {'f',0},
                {'g',0},
                {'h',0},
                {'i',0},
                {'j',0},
                {'k',0},
                {'l',0},
                {'m',0},
                {'n',0},
                {'o',0},
                {'p',0},
                {'q',0},
                {'r',0},
                {'s',0},
                {'t',0},
                {'u',0},
                {'v',0},
                {'w',0},
                {'y',0},
                {'z',0}
            };
            return alphabetUsed;
        }
    }
}
