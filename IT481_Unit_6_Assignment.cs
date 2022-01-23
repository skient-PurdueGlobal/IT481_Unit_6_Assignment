using System;

namespace IT481_Unit_6_Assignment
{
    class IT481_Unit_6_Assignment
    {
        static void Main(string[] args)
        {
            //Create random number of available rooms.
            Random rNum = new Random();
            int availRooms = 0;

            //Create random number of customers.
            Random nCust = new Random();
            int numCustomers = 0;

            //Run Scenarios
            availRooms = rNum.Next(1, 10);
            numCustomers = nCust.Next(30, 50);
            new Scenario(1, availRooms, numCustomers);

            availRooms = rNum.Next(1, 10);
            numCustomers = nCust.Next(30, 50);
            new Scenario(2, availRooms, numCustomers);

            availRooms = rNum.Next(1, 10);
            numCustomers = nCust.Next(30, 50);
            new Scenario(3, availRooms, numCustomers);

            //Display Console
            Console.Read();
        }
    }
}
