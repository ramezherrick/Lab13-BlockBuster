using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_BlockBuster
{
    class VHS : Movie
    {
        //property
        public int CurrentTime { get; set; }

        //constructor
        public VHS() { }
        public VHS (string Title, Genres Category,int RunTime, List<string> Scenes):base(Title,Category,RunTime,Scenes)
        {
            this.CurrentTime = 0;
        }
        //method
        public override void Play()
        {
            
            Console.WriteLine($"playing: {Scenes[CurrentTime]}");
            CurrentTime++;

        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
