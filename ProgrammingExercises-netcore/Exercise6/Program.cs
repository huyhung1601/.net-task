using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace CISS_ProgrammingExercise
{
    class Program
    {
        public class Line
        {
            public Point P1 { get; set; }
            public Point P2 { get; set; }
        }

        public static double ToDegrees(double radians)
        {
            return radians * 57.29578f;
        }
        public static double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0f);
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(new Random().Next(1, 200), new Random().Next(1, 200), 200, 200);

            var lines = new Program().Exercise6(rect);

            Image image = new Bitmap(rect.Right + 20, rect.Bottom + 20);
            Graphics graph = Graphics.FromImage(image);
            graph.Clear(Color.Azure);

            Pen penBl = new Pen(Brushes.Black);
            graph.DrawRectangle(penBl, rect);

            Pen p = new Pen((Brushes.Red), 1);

            if (lines != null && lines.Any())
            {
                foreach (var line in lines)
                {
                    graph.DrawLine(p, line.P1, line.P2);
                }
            }


            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                "Circle.png");

            image.Save(path, System.Drawing.Imaging.ImageFormat.Png);

            Console.WriteLine("File saved to " + path);
            Console.ReadLine();
        }




        // return a collection of line objects that will ultimately be used to render a circle on the canvas
        // the circle should be inside the bounds of the "Rect" argument (left,top,width,height)
        // the line class has 2 properties P1 & P2, that are used as drawing Points (X,Y)
        public IEnumerable<Line> Exercise6(Rectangle rect)
        {
            return null;
        }
    }
}
