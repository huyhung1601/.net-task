using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string[] files = null;
            new Program().Exercise4(Path, outFiles =>
            {
                files = outFiles;

                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            });
            Console.ReadLine();
        }

        public delegate void CompleteHandler(string[] files);

        // create a method that will scan a directory (including all sub folders)
        // looking for all files that have the .txt or .doc extension
        // the start path is passed into the "startPath" parameter.
        // the code must call the "done" handler with an array of file names when complete.
        public void Exercise4(string startPath, CompleteHandler done)
        {
            var files = Directory.GetFiles(startPath, "*.*", SearchOption.TopDirectoryOnly)
           .Where(s => s.EndsWith(".txt") || s.EndsWith(".doc")).ToArray<string>();

            var list = new List<string>();
            foreach (string file in files)
            {
                list.Add(Path.GetFileName(file));
            }
            string[] fileNames = list.ToArray();
            done(fileNames);
        }
    }
}
