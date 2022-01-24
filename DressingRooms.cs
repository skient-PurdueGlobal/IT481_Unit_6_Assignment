using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IT481_Unit_6_Assignment
{
 
    public class DressingRooms
    {
        //Variables
        private static int rooms;
        private static int maxItems = 6;
        public int items = 0;
        public double waitTime = 0;
        public double usageTime = 0;

        //Semaphore
        private static Semaphore availableRooms;

        //Constructors
        public DressingRooms()
        {
            rooms = 3;
        }
        public DressingRooms(int r)
        {
            rooms = r;
            availableRooms = new Semaphore(rooms, rooms);
        }

        //Methods
        public void RequestRoom()
        {
            int ClothingItems = 0;

            //Random number of items generator.
            Random nItems = new Random();
            if (ClothingItems == 0)
            {
                ClothingItems = nItems.Next(1, maxItems);
            }

            //Check for max items per store policy
            if (ClothingItems > 6)
            {
                //Console.WriteLine("Customer over max allowed items.");
                //ClothingItems = 6;
            }

            DateTime startWait = DateTime.Now;
            availableRooms.WaitOne();

            //Create customer.
            Customer cust = new Customer(ClothingItems);
            items += ClothingItems;

            DateTime endWait = DateTime.Now;
            TimeSpan ts = endWait - startWait;
            waitTime += ts.TotalMilliseconds;

            Console.WriteLine("-->" + Thread.CurrentThread.Name + " has entered a dressing room with " + ClothingItems + " items after waiting " + String.Format("{0:0.00}", ts.TotalMilliseconds) + " milliseconds.");
            Thread.Sleep(cust.totalTime);
            
            Console.WriteLine();
            Console.WriteLine("<--" + Thread.CurrentThread.Name + " has left the dressing room after " + (cust.totalTime) + " milliseconds.");
            usageTime += cust.totalTime;
            availableRooms.Release();
        }
    }
}
