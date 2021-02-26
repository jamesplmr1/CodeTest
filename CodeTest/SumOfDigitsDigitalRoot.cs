using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class SumOfDigitsDigitalRoot
    {
        public int DigitalRoot(long n)
        {
            long sum;

            sum = BreakNumberApart(n).Sum();
            
            if(sum >= 10)
            {
                sum = BreakNumberApart(sum).Sum();
            }

            return Convert.ToInt32(sum);
        }

        public int[] BreakNumberApart(long n)
        {
            var s = n.ToString();
            //char[] numbers = s.ToCharArray();
            int[] array = new int[s.Length];

            char y;
            for (int i = 0; i < s.Length; i++)
            {
                y = s[i];
            }

            return array;
        }
    }
}
