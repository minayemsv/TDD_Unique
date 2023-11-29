using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On_Solution
{
    public class arrange_List
    {
        public static List<int> UniNumbers(List<int> inputList)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i == 0 || inputList[i] != inputList[i - 1])
                {
                    newList.Add(inputList[i]);
                }
            }
            return newList;
        }
    }
}