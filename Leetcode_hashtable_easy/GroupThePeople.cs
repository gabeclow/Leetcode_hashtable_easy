using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_hashtable_easy
{
    public class GroupThePeople
    {

        /// <summary>
        /// There are n people that are split into some unknown number of groups. Each person is labeled with a unique ID from 0 to n - 1.
        ///You are given an integer array groupSizes, where groupSizes[i] is the size of the group that person i is in. For example, if groupSizes[1] = 3, then person 1 must be in a group of size 3.
        ///Return a list of groups such that each person i is in a group of size groupSizes[i].
        ///Each person should appear in exactly one group, and every person must be in a group.If there are multiple answers, return any of them.It is guaranteed that there will be at least one valid solution for the given input
        /// </summary>
        /// <param name="groupSizes"> groupSizes = {3,3,3,3,3,1,3} </param>
        /// <returns> [[5],[0,1,2],[3,4,6]] </returns>
        public IList<IList<int>> Grouping(int[] groupSizes)
        {
            IList<IList<int>> resultList = new List<IList<int>>();
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            for(int i=0;i<groupSizes.Length;i++)
            {
                hashTable.Add(i,groupSizes[i]);
            }
            var x = hashTable.GroupBy(x=>x.Value).ToDictionary(y => y.Key, y=> y.ToList());
            foreach(var y in x)
            {
                IList<int> list1 = new List<int>();
                var fillTo = y.Value[0].Value;
                var initialFill = 0;
                var y1 = y.Value;
                for(int i = 0; i < y1.Count; i++)
                {
                    if (initialFill == fillTo)
                    {
                        resultList.Add(list1);
                        list1 = new List<int>();
                        initialFill = 0;
                    }
                    list1.Add(y1[i].Key);
                    initialFill++;

                    //on last i, add list because initial if loop won't be hit. 
                    if (i == y1.Count - 1)
                    {
                        resultList.Add(list1);
                    }
                }
            }
            return resultList;
            
        }
    }
}
