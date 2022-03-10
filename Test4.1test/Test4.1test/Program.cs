using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._1test
{
   
    class Program
    {
       
    }
    public int[] TwoSum(int[] nums, int target)
    {
        int[] a = new int[10];
      
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length - i; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    a.Append(i);
                    a.Append(j);
                    a
                }
            }
        }
        return a;
    }
}



