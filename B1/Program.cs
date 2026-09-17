using System;
namespace B1
{
    public class Program
    {
        public void Input()
        {
            Console.Write("Input name: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Name is: {0}", name);
        }
        public static void Main(string[] str)
        {
            Program name = new();
            name.Input();
        }
    }
}