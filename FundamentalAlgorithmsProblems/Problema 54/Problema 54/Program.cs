using System;
using System.IO;

namespace Problema_54
{
    internal class Program
    {
        public class Show
        {
            public int start, end;
        }

        private static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Spectacole.txt");
            int totalShows = int.Parse(reader.ReadLine());
            Show[] shows = new Show[totalShows];

            for (int i = 0; i < totalShows; i++)
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(tokens[0] + " " + tokens[1]);
                shows[i] = new Show()
                {
                    start = int.Parse(tokens[0]),
                    end = int.Parse(tokens[1])
                };
            }

            shows = OrderShows(totalShows, shows);
            PrintShows(totalShows, shows);

            Show show = shows[0];
            int total = 1;
            string text = "(" + shows[0].start + "," + shows[0].end + ")";

            for (int i = 1; i < totalShows; i++)
            {
                if (shows[i].start >= show.end)
                {
                    total++;
                    text = text + "(" + shows[i].start + "," + shows[i].end + ")" + "\t";
                    show = shows[i];
                }
            }

            Console.WriteLine("Numarul de spectacole:" + total);
            Console.WriteLine(text);

            Console.ReadKey();
        }

        private static void PrintShows(int totalShows, Show[] shows)
        {
            Console.WriteLine();
            for (int i = 0; i < totalShows; i++)
            {
                Console.WriteLine(shows[i].start + " " + shows[i].end);
            }
        }

        private static Show[] OrderShows(int totalShows, Show[] shows)
        {
            for (int i = 0; i < totalShows; i++)
            {
                for (int j = i + 1; j < totalShows; j++)
                {
                    if (shows[i].end >= shows[j].end)
                    {
                        var aux = shows[i];
                        shows[i] = shows[j];
                        shows[j] = aux;
                    }
                }
            }

            return shows;
        }
    }
}