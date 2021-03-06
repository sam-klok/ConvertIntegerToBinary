using System;
using System.Linq;

namespace ConvertIntegerToBinary
{
    public class Program
    {
        static void Main()
        {
            for (int i = 0; i < 999; i++)
            {
                var b = ConvertIntToBin(i);
                var s = MaxCountOf1(b);

                Console.WriteLine($"{i,9} = {b,9}; {s,3}");
            }

            //Console.WriteLine(MaxCountOf1("110110111")); // 439 -> 3



        }

        static string ConvertIntToBin(long i)
        {
            string digit = Convert.ToString(i % 2);  // remainder

            if (i >= 2)
            {
                long remaining = i / 2;
                string remainingString = ConvertIntToBin(remaining);
                return remainingString + digit;
            }
            return digit;
        }


        public static int MaxCountOf1(string s)
        {
            int max = 0;
            int tempMax = 0;

            foreach (var c in s)
            {
                if (c == '1')
                {
                    tempMax += 1;
                    continue;
                }

                if (tempMax > max)
                    max = tempMax;

                tempMax = 0;
            }

            if (tempMax > max)
                max = tempMax;


            return max;
        }

        
        public static int MaxCountOf1Linq(string s)
        {
            //it's binary 0 and 1, so let's splipt by 0

            var max = s.Split('0') 
                .Max(x => x.Length);

            return max;
        }


    }
}
