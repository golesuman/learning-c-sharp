

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {10, 20, 30, 40};
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine("Element {0} is {1}", i+1, arr[i]);

        }
        Console.WriteLine("This is while loop");
        int j = 0;
        while(j < arr.Length)
        {
            Console.WriteLine("Element {0} is {1}",j+1, arr[j]);
            j++;
        }
    }
}
