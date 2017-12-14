using System;

namespace arraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int sum = 0;

            for (int i = 1; i < myArray.Length; i++)
            {
                //Console.WriteLine(myArray[i]);
                sum = myArray[i] + sum;
                Console.WriteLine(sum);
            }
            Console.ReadLine();

        }
    }
}
