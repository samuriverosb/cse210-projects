using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("PS5", 5, 499.99, 2);
        Product product2 = new Product("Dual Sense", 7, 49.99, 3);
        Product product3 = new Product("Xbox Series X", 23, 399.99, 3);
        Product product4 = new Product("Xbox Controller", 26, 39.99, 2);
        List<Product> list1 = new List<Product>();
        List<Product> list2 = new List<Product>();
        list1.Add(product1);
        list1.Add(product2);
        list2.Add(product3);
        list2.Add(product4);

        Address address1 = new Address("La Selva 29", "Villa Alemana", "Valparaiso", "Chile");
        Address address2 = new Address("First Ave. 2245", "San Diego", "California", "USA");

        Customer customer1 = new Customer("Samuel Riveros", address1);
        Customer customer2 = new Customer("Thiago Allen", address2);

        Order order1 = new Order(list1, customer1);
        Order order2 = new Order(list2, customer2);

        Console.Clear();
        Console.WriteLine("Order 1");
        order1.CalculateTotalPrice();
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine("Order 2");
        order2.CalculateTotalPrice();
        order2.PackingLabel();
        order2.ShippingLabel();
    }
}