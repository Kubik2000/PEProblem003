using System;
/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * 
 * What is the largest prime factor of the number 600851475143 ?
 */
namespace PEProblem003
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int[] EratostenesArray = new int[100000];

            for (int i = 0; i < EratostenesArray.Length; i++)
            {
                EratostenesArray[i] = i;
            }

            for (int i = 2; i < EratostenesArray.Length; i++)
            {
                if (EratostenesArray[i] != 0)
                {
                    for (int j = 2; j < EratostenesArray.Length / i; j++)
                    {
                        EratostenesArray[j * i] = 0;
                    }
                }
            }

            long number = 600851475143;
            int result = 0;
            for (int i = EratostenesArray.Length - 1; i > 2; i--)
            {
                if (EratostenesArray[i] != 0)
                {
                    if (number % EratostenesArray[i] == 0)
                    {
                        result = EratostenesArray[i];
                        break;
                    }
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
