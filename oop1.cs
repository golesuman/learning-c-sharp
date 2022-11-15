using System;

public class Animal
{
    string name = "Dog";
    
    public static void Main(string[] args)
    {
       Animal a1 = new Animal();
    //   Console.WriteLine(a1.name);
       a1.name = "cat"; //overriding the class variables
       Console.WriteLine(a1.name);
    }
}
