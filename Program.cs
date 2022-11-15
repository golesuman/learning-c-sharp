using System;

namespace learning_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10, secondNumber = 20;
            Console.WriteLine("first number is {0} and second number is {1}", firstNumber, secondNumber);
            int number = 10;
            bool result = (number > 20) ? true : false;
            Console.WriteLine(result);
        }
    }
}
