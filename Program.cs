using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Iseseisevtöö
{
    class tasks
    {
        static void Main(string[] args)
        {

            //TASK1
            int[] numbers = new int [7] { 10, 11, 12, 13, 14, 15, 16 };
            int max_value = 0;
            int min_value = 0;
            int n1 = max_value + numbers[6];
            int n2 = min_value + numbers[0];
            int answer = n1 - n2;
            Console.WriteLine(answer);
            //TASK1

            //TASK2
            int[] numbers = { -12, -99, 9, 122, 170, 50 };
            int count = numbers.Count(x => x > 0 && x < 125);
            Console.WriteLine(count);
            //TASK2


            //TASK3
            List<string> players = new List<string>();
            players.Add("Johhny Boy");
            players.Add("Baby man");
            players.Add("Bunda Junior");
            players.Add("Bunda Senior");
            players.Add("Artur");

            int counter = 0;
            int murder = 2;

            Console.WriteLine("Players");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();

            foreach (string player in players)
            {
                counter++;
                if (counter == 2)
                {
                    break;
                }
            }

            if (counter == murder)
            {
                players.RemoveAt(counter - 1);
            }

            Console.WriteLine("Players");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();

            if (counter == murder)
            {
                players.RemoveAt(counter - 1);
            }

            Console.WriteLine("Players");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();

            if (counter == murder)
            {
                players.RemoveAt(counter - 1);
            }

            Console.WriteLine("Players");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();

            if (counter == murder)
            {
                players.RemoveAt(counter - 1);
            }

            Console.WriteLine("Players");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();

            //TASK3
        }

    }
}
