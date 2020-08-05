using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Lab13_BlockBuster
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to GC Blockbuster!");
            BlockBuster blockBuster = new BlockBuster();
            DVD dvd = new DVD();
            VHS vhs = new VHS();

            //blockBuster.PrintMovies();

            Movie selectedMovie = blockBuster.CheckOut();

            string wantToWatch = GetUserInput("\nDo you want to watch the movie? (y/n)");

            if (wantToWatch == "y")
            {
                if(selectedMovie is VHS)
                {
                    vhs = (VHS)selectedMovie; // Unboxing

                    Console.WriteLine($"\nThis: {selectedMovie.GetType().Name} {selectedMovie.Title} has {selectedMovie.Scenes.Count} scenes");

                    //Extended Exercise:
                    //Create a PlayWholeMovie in both VHS and DVDs to play each scene from start to finish.
                    
                    for (int i =0;i<selectedMovie.Scenes.Count;i++)
                    {
                        vhs.Play();
                    }
                    
                    string rewind = GetUserInput("\nwould you like to rewind and watch again? (y/n)");
                    if (rewind == "y")
                    {
                        vhs.Rewind();
                        for (int i = 0; i < selectedMovie.Scenes.Count; i++)
                        {
                            vhs.Play();
                        }
                    }
                }
                else
                {
                    selectedMovie.Play();
                }
            }

            Console.WriteLine("\nbye");
        }
        public static string GetUserInput (string str)
        {
            Console.Write(str);
            string input = Console.ReadLine();
            return input;
        }
    }
}
