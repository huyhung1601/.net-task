using System;
using System.IO;

namespace CISS_ProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string exepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string exe1 = Path.Combine(exepath, "day.png");
            string exe2 = Path.Combine(exepath, "foggy.png");
            string exe3 = Path.Combine(exepath, "logo.png");
            string exe4 = Path.Combine(exepath, "logo2.png");

            string[][] Tests = {
                new string[] {exe1,exe2},
                new string[] {exe3,exe3},
                new string[] {exe3,exe2},
                new string[] {exe3,exe4}
            };

            foreach(var t in Tests){
                string result = Exercise2(t[0],t[1]) ? "The files match" : "The files do not match";
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        // this method will be called several times with paths to 2 files.
        // the method should return true if the file contents match (files are equal)
        // and false if the file contents do not match.
        public static bool Exercise2(string filePath1, string filePath2)
        {
            if (filePath1 != filePath2 )
            {
                return false
            }
            return true;
        }
    }
}
