using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_hashtable_easy
{
    public class CountConsistentStrings
    {


        public int CountAllConsistentStrings(string allowed, string[] words)
        {
            int num = words.Length;
            int total = 0;

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var c in words[i].ToCharArray())
                {
                    if (!allowed.Contains(c))
                    {
                        total++;
                        break;
                    }
                }
            }
            return num - total;
        }
    }
}
