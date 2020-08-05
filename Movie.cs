using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_BlockBuster
{
    abstract class Movie
    {
        //properties
        public string Title { get; set; }
        public Genres Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        //constructor
        public Movie() { }
        public Movie(string Title, Genres Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        //methods
        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"The title is: {Title}");
            Console.WriteLine($"The Category is: {Category}");
            Console.WriteLine($"The RunTime is: {RunTime}");
        }
        public void PrintScenes()
        {
            for (int i=0;i<Scenes.Count;i++)
            {
                Console.WriteLine($"Index is: {i} and Scene is {Scenes[i]}");
            }
        }
        public abstract void Play();     
    }
}
