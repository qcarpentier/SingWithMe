using System;
using System.Collections.Generic;
using System.Text;

namespace SingWithMe
{
    public class Singer
    {
        public static void WriteLine(string line)
        {
            // Split the line, first take the text, and then the time
            var results = line.Split(':');
            WriteLine(results[0], int.Parse(results[1]));
        }

        public static void WriteLine(string line, int time)
        {
            // Speed for characters to appear on the screen
            var speed = time / line.Length;
            foreach (var letter in line.ToCharArray())
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}
