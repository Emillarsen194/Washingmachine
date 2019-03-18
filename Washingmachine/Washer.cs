using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Washingmachine
{
    class Washer
    {
        public bool power;
        //public bool door;
        //private bool soapdoor;
        public String program;
        private int time;

        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }


        public Washer()
        {

        }
         public Washer(bool onoff)
        {
            this.power = onoff;
      
        }
         


        public bool PowerOnOff(bool power)
        {
            return power;
        }
     

        public int Timer(String whatprogram)
        {
            
            int seconds = 0;
            while (time > seconds)
            {
                seconds++;
                Console.WriteLine("running " + whatprogram + " for: " + seconds + " seconds"); // progrma been running for 
                Thread.Sleep(1000);
                Console.Clear();
            }

            if (time <= seconds)
            {
                Console.WriteLine(whatprogram + " done running"); // when done running tell done running 
            }

            power = false; // and turn off power 
           
            return seconds; // return seconds 

            
        }

        //public int UseSoap()
        //{

        //}
           
        //public int UseWater()
        //{

        //}

        public String Fill()
        {
            time = 5; //fill program is only running for 5 seconds 

 
            return "program fill"; 
     
        }

            

        public String Wash()
        {
            time = 10; // wash program running for 5 seconds
            return "Program Wash";
        }

        public String EcoWash()
        {
            time = 20; // ecowash running for 20 seconds 
            return "program ecoWash";
        }
    }
}
