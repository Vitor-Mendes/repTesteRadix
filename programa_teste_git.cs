using System;

namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            double x = 0;
            Console.WriteLine("Hello World!");
            string aux = Console.ReadLine();
            double.TryParse(aux, out x);
            Console.WriteLine(" Esse é o X = "+ x);
        }
    }
}
