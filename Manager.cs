using System.Collections;

public class Manager
{
  

    List<Product> products = new List<Product>();

    public Manager()
    {
        Product product1 = new Product("Compressor");
        Product product2 = new Product("Arrefecimento e compressor");
        Product product3 = new Product("Unidade condensadora completa");
        Product product4 = new Product("Unidade ventiladora completa");
        Product product5 = new Product("Sistema anlógico");
        Product product6 = new Product("Sistema digital");

        Compressor compressor = new Compressor();
        Cooling cooling = new Cooling();
        Condenser condenser = new Condenser();
        Fan fan = new Fan();
        AnalogController analogController = new AnalogController();
        DigitalController digitalController = new DigitalController();

        product1.AddComponent(compressor);

        product2.AddComponent(compressor);
        product2.AddComponent(cooling);

        product3.AddComponent(compressor);
        product3.AddComponent(cooling);
        product3.AddComponent(condenser);

        product4.AddComponent(compressor);
        product4.AddComponent(cooling);
        product4.AddComponent(condenser);
        product4.AddComponent(fan);

        product5.AddComponent(compressor);
        product5.AddComponent(cooling);
        product5.AddComponent(condenser);
        product5.AddComponent(fan);
        product5.AddComponent(analogController);

        product6.AddComponent(compressor);
        product6.AddComponent(cooling);
        product6.AddComponent(condenser);
        product6.AddComponent(fan);
        product6.AddComponent(digitalController);

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);
        products.Add(product6);
    }


    public void Print()
    {
        Console.WriteLine("Produto | \t\tComponentes | \t\tCusto de fabricação");
        foreach (Product product in products)
        {
            product.Print();
        }
    }
}