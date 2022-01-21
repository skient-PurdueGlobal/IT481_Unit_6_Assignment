using System;
using System.Collections.Generic;
using System.Text;

namespace IT481_Unit_6_Assignment
{
    public class Scenario
    {
        //Variables

        //Constructors
        public Scenario() { }
        public Scenario(int sCase, int rAvail, int nCust)
        {
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
                    Console.WriteLine("********************* Scenario 2 *********************");
                    break;
            }

            //Run Scenario
            //Create rooms as specified.
            DressingRooms rooms = new DressingRooms(rAvail);

            //Create customers as specified.

        }
    }
}
