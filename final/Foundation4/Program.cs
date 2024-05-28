using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer= new Customer("Samuel","24","las mingas 1348","Peru");
        customer.Llamar();

        Customer customer1= new Customer("Pepe","24","las mingas 1348","Francia");
        customer1.Llamar();
    }
}