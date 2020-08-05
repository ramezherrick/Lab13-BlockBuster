using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab13_BlockBuster
{
    class DVD : Movie
    {
        //constructor
        public DVD() { }
        public DVD(string Title, Genres Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
          
        }
        public override void Play()
        {
            string watchAnotherScene = "y";
    
            while (watchAnotherScene == "y")
            {
                //Extended Exercise:
                //Create a PlayWholeMovie in both VHS and DVDs to play each scene from start to finish.

                Console.WriteLine("\nEnter (1) to watch by scenes");
                Console.Write("Enter (2) to watch from start to finish");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                Console.WriteLine($"\nWhich Scene of the {this.GetType().Name} {Title}");
                Console.WriteLine($"would you like to watch? Available scenes are {Scenes.Count} ");

                for (int i = 0; i < Scenes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Scenes[i]}");
                }

                Console.Write("\nyour selection: ");
                int start = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nplaying {Scenes[start-1]}");

  
                Console.Write("\nWatch another scene? (y/n) ");
                watchAnotherScene = Console.ReadLine().ToLower();

                if (watchAnotherScene != "y") break;
                }
                if (choice == 2)
                {
                    for (int i = 0; i < Scenes.Count; i++)
                    {
                        Console.WriteLine($"playing {Scenes[i]}");
                    }
                    break;
                }

            }
        }
    }
}
