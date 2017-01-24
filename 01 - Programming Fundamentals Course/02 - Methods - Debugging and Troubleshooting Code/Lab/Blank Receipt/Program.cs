using System;

namespace Blank_Receipt
{
    class Program
    {
        public static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Body (){
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        public static void PrintReceipt()
        {
            Header();
            Body();
            Footer();
        }

        public static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
