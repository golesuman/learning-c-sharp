using System;

public class Animal
{
    // string name = "Dog";
    
    public static int add(int a, int b){
        return a+b;
    }
    
    
    public static void Main(string[] args)
    {
       int sum = add(5, 6);
       Console.WriteLine(sum);
    }
}
