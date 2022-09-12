using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
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

            foreach (var t in Tests)
            {
                string result = Exercise2(t[0], t[1]) ? "The files match" : "The files do not match";
                Console.WriteLine(result);
            };
            Console.ReadLine();
        }
        // this method will be called several times with paths to 2 files.
        // the method should return true if the file contents match (files are equal)
        // and false if the file contents do not match.
        public static bool Exercise2(string filePath1, string filePath2)
        {
            var filename1 = System.IO.Path.GetFileName(filePath1);
            var filename2 = System.IO.Path.GetFileName(filePath2);

            var bitmap1 = GetHash(Image.FromFile(filePath1, true));
            var bitmap2 = GetHash(Image.FromFile(filePath2, true));

            bool compare = true;

            for (int i = 0; i < (bitmap1.Count > bitmap2.Count ? bitmap1.Count : bitmap2.Count); i++)
            {
                if (bitmap1[i] != bitmap2[i])
                {
                    compare = false;
                }
            }

            return compare;
        }

        public static List<bool> GetHash(Image bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }
    }
}
