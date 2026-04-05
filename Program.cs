////I created it in a separate folder just so the riposatory  be a single link.

//namespace ClassLibrary1
//{
//    public enum OrderStatus { Pending, Processing, Shipped, Delivered }
//    public class Order
//    {
//        public string CustomerName;
//        public double Amount;
//        public OrderStatus Status;

//        public Order(string name, double amount, OrderStatus status)
//        { CustomerName = name; Amount = amount; Status = status; }

//        public Order(string name) : this(name, 0, OrderStatus.Pending) { }
//        public Order() : this("Guest") { }
//        // A) Pass by Value — original amount stays unchanged
//        public double CalcTotal(double taxPercent)
//        {
//            return Amount + (Amount * taxPercent / 100);
//        }

//        // B) Pass by Reference — wallet is updated directly
//        public void Pay(ref double walletBalance)
//        {
//            walletBalance -= Amount;
//            Status = OrderStatus.Processing;
//        }
//    }
//}
using ClassLibrary1;
namespace ConsoleApp1

{
    using System;
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter Wallet Balance: ");
            double wallet = double.Parse(Console.ReadLine());

            Order order = new Order(name, amount, OrderStatus.Pending);

            Console.WriteLine("\nCustomer Name    : " + order.CustomerName);
            Console.WriteLine("Amount           : " + order.Amount);
            Console.WriteLine("Status           : " + order.Status);
            Console.WriteLine("Amount After Tax : " + order.CalcTotal(14));

            Console.WriteLine("");
            Console.WriteLine("Customer Data");
            Console.WriteLine("Wallet Balance Before Pay : " + wallet);
            Console.WriteLine("Order Status Before Pay   : " + order.Status);

            order.Pay(ref wallet);

            Console.WriteLine("Wallet Balance After Pay  : " + wallet);
            Console.WriteLine("Order Status After Pay    : " + order.Status);
        }
    }
}
