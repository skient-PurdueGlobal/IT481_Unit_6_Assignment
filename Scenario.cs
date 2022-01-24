using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IT481_Unit_6_Assignment
{
    public class Scenario
    {
        //Variables
        private static Thread[] custThreads;

        //Constructors
        public Scenario() { }
        public Scenario(int sCase, int rAvail, int nCust)
        {
            DateTime start = DateTime.Now;
            double totalItems = 0;
            double totalWait = 0;
            double totalUsage = 0;

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
            DressingRooms rooms = new DressingRooms(rAvail);

            //Generate random number of customer items and create customer threads.
            custThreads = new Thread[nCust];
            for (int i = 0; i < nCust; i++)
            {
                custThreads[i] = new Thread(rooms.RequestRoom);
                custThreads[i].Name = "Customer " + (i + 1);
                custThreads[i].Start();
            }

            if (custThreads != null)
            {
                foreach (Thread t in custThreads)
                {
                    t.Join();
                }
            }

            //Display Scenario Stats
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            totalItems = rooms.items;
            totalWait = rooms.waitTime;
            totalUsage = rooms.usageTime;

            Console.WriteLine();
            Console.WriteLine("**Scenario Statistics**");
            Console.WriteLine("Total elapsed scenario time: " + String.Format("{0:0.00}",ts.TotalMilliseconds) + " milliseconds.");
            Console.WriteLine("Total items: " + totalItems + " items.");
            Console.WriteLine("Average items per customer: " + String.Format("{0:0.00}", (totalItems / nCust)) + " items.");
            Console.WriteLine("Average usage time per room: " + String.Format("{0:0.00}", totalUsage / nCust) + " milliseconds.");
            Console.WriteLine("Average time spent waiting per customer: " + String.Format("{0:0.00}", totalWait / nCust) + " milliseconds.");

            Console.WriteLine();
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
