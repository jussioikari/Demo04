using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht001
{
    class Hissi
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;
       

        private int floor=1;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Floor to small! Going to floor 1");
                    floor = minFloor;
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Floor to big! Going to floor 5");
                    floor = maxFloor; }
                else
                {
                    floor = value;
                }
                
              
            }


        }
        
        
        
        }
        
        
        
    }

