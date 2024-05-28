using System;

class Program
{
    static void Main(string[] args)
    {
      Producto producto1=new Producto("Laptop","P001",1000,2);
      Producto producto2=new Producto("Headphones","P002",50,3);

      Address address1=new Address("123 Main St","Anyrown","CA","USA");

      Customer customer1=new Customer("Samuel Reyes",address1);

      Order order1=new Order(customer1);
      order1.AddProduct(producto1);
      order1.AddProduct(producto2);

      Console.WriteLine("Order 1 Packing Label: ");
      Console.WriteLine(order1.GeneratePackingLabel());

      Console.WriteLine("\nOrder 1 Shipping Label: ");
      Console.WriteLine (order1.GenerateShippingLabel());

      Console.WriteLine("\nOrder 1 Total Price: ");
      Console.WriteLine("$"+ order1.CalculateTotalCost());
      
      // Creating products for another order
        Producto product3 = new Producto("Smartphone", "P003", 800, 1);
        Producto product4 = new Producto("Tablet", "P004", 400, 2);

        // Creating address for another customer
        Address address2 = new Address("456 Elm St", "Sometown", "NY", "Canada");

        // Creating another customer
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating another order
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Displaying another order details
        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine("$" + order2.CalculateTotalCost());
    }
}