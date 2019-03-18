using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Washingmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = false;
            Console.WriteLine("Do u wanna turn on the washing machine? yes or no");
            String yesNo = Console.ReadLine().ToLower() ;

            if (yesNo == "yes")
            {
                power = true; // then power is true 
            }

            else
            {
                power = false; // Else dont turn on the washing machine 
            }
            Washer washingnow = new Washer(power); //making new washer object with power 

            if (washingnow.power == true) // if washingnow.property power is true 
            {


            Console.WriteLine("what program do u wanna use fill, ecowash, wash");
            String programs = Console.ReadLine(); //choose program





            String whatProgram = "";

                int timer = 0; // our timer to check how long program been running for 

            

            switch (programs)
            {
                case "wash":
                    whatProgram = washingnow.Wash(); //wash method normal program 
                        timer = washingnow.Timer(whatProgram);
                    break;
                case "ecowash":
                    whatProgram = washingnow.EcoWash(); //Eco was method 
                        timer = washingnow.Timer(whatProgram);
                    break;
                case "fill":
                    whatProgram = washingnow.Fill(); // fill washing program 
                        timer = washingnow.Timer(whatProgram);
                    break;
            }
                


                    Console.WriteLine(timer); // writes our timer 

                
            }




        }
    }
}
