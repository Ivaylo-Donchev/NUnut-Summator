using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr) 
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {   
                sum += arr[i];
            }

            return sum;
        }

        public static double Average(int[] arr) 
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            //Return SUM
            return sum* arr.Length;
        }
        
        }
    }
}
