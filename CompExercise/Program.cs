using System;
using System.Collections.Generic;
using CompExercise.Entities;
using CompExercise.Entities.Enum;

namespace CompExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                Console.Write($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);


        }
    }
}
