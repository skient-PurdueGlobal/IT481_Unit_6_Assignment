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

        //Constructors
        public DressingRooms()
        {
            rooms = 3;
        }
        public DressingRooms(int r)
        {
            rooms = r;
        }

        //Semaphore
        private static Semaphore availableRooms = new Semaphore(initialCount: 0, maximumCount: rooms);

        //Methods
        public void RequestRoom()
        {
            availableRooms.WaitOne();
        }
    }
}
