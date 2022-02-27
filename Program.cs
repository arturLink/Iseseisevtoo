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
            //int[] numbers = new int [7] { 10, 11, 12, 13, 14, 15, 16 };
            //int max_value = 0;
            //int min_value = 0;
            //int n1 = max_value + numbers[6];
            //int n2 = min_value + numbers[0];
            //int answer = n1 - n2;
            //Console.WriteLine(answer);


            //Random numb = new Random();
            //int[] k = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    k[i] = numb.Next(-3, 180);
            //}


            Dictionary<int, string> humans = new Dictionary<int, string>(5);
            humans.Add(1, "vasja");
            humans.Add(2, "petja");
            humans.Add(3, "andrei");
            humans.Add(4, "nikita");
            humans.Add(5, "alenka");

            Console.WriteLine("Remaining players:");
            Console.WriteLine(humans);

            Random rnd = new Random();
            int murderindex = rnd.Next(humans.Count);
            humans.Remove(murderindex);
            Console.WriteLine("Remaining players:");
            Console.WriteLine(humans);
        }
    }
}
