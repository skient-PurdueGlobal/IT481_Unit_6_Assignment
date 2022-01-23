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

        //Semaphore
        private static Semaphore availableRooms;

        //Constructors
        public DressingRooms()
        {
            rooms = 3;
        }
        public DressingRooms(int r, int c)
        {
            rooms = r;
            availableRooms = new Semaphore(0, rooms);

            //Create customers as specified.
//            for (int i = 0; i < c; i++)
//            {
//                Random nItem = new Random();
//                int numItems = nItem.Next(0, maxValue));
//
//                //Generate random number of items.
//                if (numItems == 0)
//                {
//                    //numItems
//                }
//
                //Create new customer and thread.
//                new Customer(i + 1, numItems);
//            }

//            Thread.Sleep(500);

//            availableRooms.Release();
//            Console.WriteLine("Customer " + c + " has left the dressing room.");
        }
        //Methods
        public void RequestRoom(int c)
        {
            Console.WriteLine("Customer " + c + " is waiting on a dressing room");

            availableRooms.WaitOne();

            Console.WriteLine("Customer " + c + " has entered a dressing room");
            
        }
    }
}
