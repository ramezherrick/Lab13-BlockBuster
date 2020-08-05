using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Lab13_BlockBuster
{
    class BlockBuster
    {
        public List<Movie> Movies = new List<Movie>
        {
            new VHS("Star Wars", Genres.scifi, 120, new List<string>(){"sc1" }),
            new VHS("Duck Tales", Genres.animated, 120, new List<string>(){"sc1","sc2" }),
            new VHS("Marvel ", Genres.scifi, 120, new List<string>(){"sc1","sc2","sc3" }),
            new DVD("Saving Private Ryan", Genres.action, 350, new List<string>(){"sc1","sc2","sc3","sc4" }),
            new DVD("Duck Tales 2: Zack Quack has a bad day", Genres.animated, 120, new List<string>(){"sc1","sc2","sc3","sc5" }),
            new DVD("Dora The Explorer: Swiper, yes Swiping!", Genres.animated, 120, new List<string>(){"sc1","sc2","sc3","sc6" }),
            
        };
        public void PrintMovies()
        {
            Console.WriteLine("\nPlease select a movie from the list\n");
            for (int i =0;i<Movies.Count;i++)
            {
                
                Console.WriteLine($"{i+1}) {Movies[i].Title}" ); 
            }
    
        }
        public Movie CheckOut()
        {
            PrintMovies();

            Console.Write("\nPlease select a movie you want to watch:");

            int index = int.Parse(Console.ReadLine());

            Movies[index-1].PrintInfo();

            return Movies[index-1];
        }

    }
}
