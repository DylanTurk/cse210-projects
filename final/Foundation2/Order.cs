using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (var product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        Address address1 = _customer.GetAddress();
        Console.WriteLine($"Name: {_customer.GetName()}, Address: {address1.GetFullAddress()}");
    }
}
