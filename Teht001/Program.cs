using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht001
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            
            
            Console.WriteLine("Elevator is on floor: " + hissi.Floor);
            int luku ;
            do
            {
                Console.WriteLine("Give new floor 1-5: ");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                hissi.Floor = luku;
                Console.WriteLine("Elevator is on floor " + hissi.Floor);
                
            }
            while (luku != 0);
        }
    }
}
