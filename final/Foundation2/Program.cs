using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Customer cust1 = new Customer(
            "Miguel Escudo",
            new Address(
                "1282 El Oso Dr.",
                "Pucallpa",
                "Centenario",
                "Peru")
        );
        
        Customer cust2 = new Customer(
            "Noah Arkenson",
            new Address(
                "1502 Gamoora Road",
                "Sodom",
                "SaltState",
                "USA")
        );
        
        Product prod1 = new Product(
            "Milk",
            1286,
            2.59,
            3
        );
        
        Product prod2 = new Product(
            "Eggs",
            8762,
            5.89,
            5
        );
        
        Product prod3 = new Product(
            "Chips",
            0943,
            4.75,
            2
        );
        
        Product prod4 = new Product(
            "Socks",
            3841,
            10.59,
            1
        );
        
        Product prod5 = new Product(
            "Mike & Ikes",
            9481,
            189.12,
            40
        );
        
        Order order1 = new Order(cust1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        
        Order order2 = new Order(cust2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);
        
        Console.WriteLine("-------------- ORDER 1 --------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("   TOTAL PRICE: $"+order1.GetTotalCost().ToString());
        
        Console.WriteLine("");
        
        Console.WriteLine("-------------- ORDER 2 --------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("   TOTAL PRICE: $"+order2.GetTotalCost().ToString());
        
    }
}