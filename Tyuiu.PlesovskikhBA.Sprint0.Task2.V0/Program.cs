using System;
using Tyuiu.PlesovskikhBA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PlesovskikhBA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Борис"));
            Console.ReadKey();
        }
    }
}
