using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Iseseisevtöö
{
    public class Functions
    {
        public void ShowPlayers(string[] players)
        {
            Console.WriteLine("Players:");
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
