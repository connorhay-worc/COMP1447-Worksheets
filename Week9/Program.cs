using System;

namespace Week9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string[] names = new string[3];
            // names[0] = "Chris";
            // names[1] = "Richard";
            // names[2] = "Mark";
            // Console.WriteLine("Element 0: " + names[0]);
            // Console.WriteLine("Element 1: " + names[1]);
            // Console.WriteLine("Element 2: " + names[2]);
            // Console.WriteLine("My amazing lecturers are: {0}, {1} and {2}", names);

            int[] numbers = new int[5] { 3, 16, 43, 18, 22 };
            // int sumResult = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            // // Console.WriteLine(sumResult);
            // string sumString = $"Manual sum: {sumResult}";
            // Console.WriteLine(sumString);
            numbers[1] = 66;
            numbers[4] = 72;

            // int loopSumResult = 0;
            // for (int i = 0; i < 5; i++)
            // {
            //     loopSumResult += numbers[i];
            // }
            // Console.WriteLine("Loop sum: {0}", loopSumResult);

            numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 100;
            }
        }
    }
}