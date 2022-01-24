using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IT481_Unit_6_Assignment
{
    public class Customer
    {
        //Variables
        public int ClothingItems = 0;
        public int totalTime = 0;
        
        //Constructors
        public Customer() { }
        public Customer(int NumberOfItems)
        {
            ClothingItems = NumberOfItems;

            for (int i = 1; i <= ClothingItems; i++)
            {
                //Create random timer for time to change clothes
                Random time = new Random();
                totalTime += time.Next(60, 180); 
            }
        }

        //Methods
    }
}
