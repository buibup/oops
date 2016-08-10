using System;

namespace oops
{
    class customer
    {
        // class members code

        //Entry point
        static void Main(string[] args)
        {
            // object instantiation
            customer obj = new customer();

            //Method calling
            obj.displayData();

            //fields calling
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
        }

        // Member Variables
        public int CustID;
        public string Name;
        public string Address;

        //constructor for initializing fields
        customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Adress=" + Address);
        }
    }
}
