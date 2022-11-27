using System.Collections;

public class Product
{
    public string Name {get;set;} = "HVAC - ";
    public float Cost {get;set;}

    List<Component> components = new List<Component>();

    public Product(string name)
    {
        Name += name;
    }

    public void AddComponent(Component component)
    {
        components.Add(component);
        Cost += component.Cost;
    }

    public void Print()
    {
        Console.Write(Name + "\t");
        foreach (Component component in components)
        {
            component.Print();
            Console.Write("\t");
        }
        Console.Write(String.Format("{0:.00}\n", Cost));
    }
}