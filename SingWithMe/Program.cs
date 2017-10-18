using System;
using System.IO;

namespace SingWithMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new string[] { "song1", "song2", "song3" };

            Console.WriteLine("Welcome!");
            Console.WriteLine("Do you want to sing with me?");
            Console.WriteLine("Of course yes!");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Please select a song:");
                Console.WriteLine($"1 - {songs[0]}");
                Console.WriteLine($"2 - {songs[1]}");
                Console.WriteLine($"3 - {songs[2]}");
                Console.WriteLine("q to Quit");
                Console.WriteLine();

                string input = Console.ReadLine();

                if(input.ToLower() == "q")
                {
                    break;
                }

                int song = 0;
                if (!int.TryParse(input, out song))
                {
                    Console.WriteLine("Your selection is incorrect, try again");
                    continue;
                }
                // Decrement the song to have the correct array index
                song--;

                var fileName = songs[song] + ".txt";
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found, try again");
                    continue;
                }
            }
        }
    }
}