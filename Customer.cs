using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IT481_Unit_6_Assignment
{
    public class Customer
    {
        //Variables
        Thread t;
        int numItems;
 
        //Constructors
        public Customer() { }
        public Customer(int c, int nItems)
        {
            numItems = nItems;

            t = new Thread(this.Try_On);
            t.Name = "Customer " + c.ToString();

            t.Start();
        }

        //Methods
        public void Try_On()
        {

            Console.WriteLine(t.Name + " has " + numItems + " items to try on.");
        }
    }
}
