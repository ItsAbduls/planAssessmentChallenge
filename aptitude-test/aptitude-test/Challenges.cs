using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptitude_test
{
    public class Challenges
    {
        public int Challenge(int[] input)
        {
            List<int> list = input.OfType<int>().ToList();
            var elementsGroup = list.GroupBy(x => x).Where(chunk=> chunk.Count()>1).Select(el => el.ToList().Take(3)).ToList();
            var filteredList = elementsGroup.SelectMany(x => x).ToArray();

            int max = filteredList[0] + filteredList[1];
            for (int x = 1; x <= filteredList.Length - 2; x++)
            {
                max = Math.Max(max, filteredList[x] + filteredList[x + 1]);
            }
            return max;
        }


    }
}
