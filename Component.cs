public class Component
{
    public string Name{get;set;} = "Componente";
    public float Cost{get; set;}

    public void Print()
    {
        Console.Write(Name + " |");
    }
}