using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IT481_Unit_6_Assignment
{
    public class Scenario
    {
        //Variables
        int maxItems = 6;

        //Constructors
        public Scenario() { }
        public Scenario(int sCase, int rAvail, int nCust)
        {
            Console.WriteLine();

            //Determine which scenario.
            switch (sCase)
            {
                case 1: 
                    Console.WriteLine("********************* Scenario 1 *********************");
                    break;
                case 2:
                    Console.WriteLine("********************* Scenario 2 *********************");
                    break;
                case 3:
                    Console.WriteLine("********************* Scenario 3 *********************");
                    break;
            }

            Console.WriteLine("Available Rooms: " + rAvail);
            Console.WriteLine("Number of Customers: " + nCust);
            Console.WriteLine();

            //Run Scenario
            //Create rooms as specified and customers as specified.
            DressingRooms rooms = new DressingRooms(rAvail, nCust);

            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
