using System;
using System.Threading;

namespace CISS_ProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                var Time = Exercise1(i);
                Console.WriteLine(Time);
                Thread.Sleep(1000);
            }
        }

        // this method will be called periodically.
        // make the method return a string that contains the number of seconds
        // from the first time the method is called to the current time
        // example: 
        // 1 Second, 2 Seconds, 3 Seconds ect.
        public static string Exercise1(int i)
        {
            string result = Convert.ToString(i) + (i < 2 ? " second" : " seconds");
            return result;
        }
    }
}
