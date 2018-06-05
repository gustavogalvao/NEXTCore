using System;

namespace NEXTLogisticsCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 2, 5, 7, 3, 7, 8, 9, 26, 16, 1, 2, 3, 1, 4, 5, 1 };
            int[] output1 = GetTopThreeSums(input1);

            int[] input2 = { 3, 7, 9, 5, 3, 56, 8, 0, 2, 56, 7, 6, 4 };
            var output2 = GetTopThreeSums(input2);

            int[] input3 = { 3, 6, 9, 5, 6, 56, 8, 78, 2, 56, 7, 10, 5, 59 };
            int[] output3 = GetTopThreeSums(input3);
            for (int i = 0; i < output3.Length; i++) {
                Console.WriteLine(output3[i].ToString());
            }
        }

        public static int[] GetTopThreeSums(int[] numbers)
        {
            int sum = 0;
            int cluster = 2;

            System.Collections.ArrayList intArray = new System.Collections.ArrayList(); 

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];

                if (i == cluster) 
                {
                    intArray.Add(sum);
                    cluster = cluster + 3;
                    sum = 0;
                }
            }

            int[] arrayTest = intArray.ToArray(typeof(int)) as int[];
            Array.Sort(arrayTest);
            Array.Reverse(arrayTest);

            int[] output = new int[3];
            for (int i = 0; i < 3; i++)
            {
                output[i] = arrayTest[i];
            }

            return output;
        }
    }
}
