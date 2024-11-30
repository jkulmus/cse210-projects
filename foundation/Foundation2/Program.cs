using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("Street", "City", "State", "Country");
        Address address2 =  new Address("Street", "City", "State", "Country");

        //Create customers
        Customer customer1 = new Customer("Name", address1);
        Customer customer2 = new Customer("Name", address2);

        // Create products
        Product product1 = new Product("Item", "100", 1.10m, 1);
        Product product2 = new Product("Item", "101", 5.99m, 2);
        Product product3 = new Product("item", "102", 3.50m, 1);

        // Create orders and add products
        Order order1 =  new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        //Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}\n");

        //Diplay Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():C}");

    }
}