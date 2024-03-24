using System;

namespace tpmodul6_1302220009
{
    class Program
    {
        public class SayaTubeVideo
        {
            private int id;
            string title;
            private int playCount;

            public SayaTubeVideo(string title)
            {
                var rand = new Random();
                this.id = rand.Next(9999);
                this.title = title;
                this.playCount = 0;
            }

            public void IncreasePlayCount(int jmlh)
            {
                playCount += jmlh;
            }

            public void PrintVideoDetails()
            {
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Play count: " + playCount);
            }
        }


        static void Main(string[] args)
        {
            SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design By Contract – Marjauza Naswansyah");
            vid1.IncreasePlayCount(1000);
            vid1.PrintVideoDetails();
            Console.ReadLine();
        }
    }
}