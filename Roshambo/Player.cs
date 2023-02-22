using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    abstract class Player  // Base class (parent)
    {
        public string name { get; set; }
        public virtual void RoshamboValue()
        {
            Console.WriteLine("You have chosen ");
        }
        public string choice { get; set; }

        public void GenerateRoshambo()
        {
            Random rd = new Random();

            int rand_num = rd.Next(1, 3);

            if (rand_num == 1)
            {
                choice = "Rock";
            }
            else if (rand_num == 2)
            {
                choice = "Paper";
            }
            else

                choice = "Scissors";
        }

    }                   
        
    
    class Rock : Player
    {
        public override void RoshamboValue()
        {
            Console.WriteLine(name + " has selected " + choice);
        }
    }
    
    class Any : Player
    {
              
        public override void RoshamboValue() 
        {

            GenerateRoshambo(); 
            Console.WriteLine(name + " has selected " + choice + "!");
            
        }

             
    }
  
    
    class Human : Player
    {
       
        public override void RoshamboValue()
        {
                       
            Console.WriteLine(name + " has selected " + choice + "!");
            
        }
    }
   
}
