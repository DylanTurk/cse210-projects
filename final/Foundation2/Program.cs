using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "LP1001", 999.99, 1);
        Product product2 = new Product("Mouse", "MS2002", 25.50, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Product product3 = new Product("Smartphone", "SP3003", 599.99, 1);
        Product product4 = new Product("Headphones", "HP4004", 89.99, 1);
        Product product5 = new Product("Charger", "CH5005", 19.99, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;
        foreach (var order in orders)
        {
            Console.WriteLine($"--- Order {orderNumber} ---");
            order.GetPackingLabel();
            Console.WriteLine();
            order.GetShippingLabel();
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
            orderNumber++;
        }
    }
}
