using System;

namespace Exam
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Enter the dimenstions of the Cylinder");
            Console.WriteLine("Radius: ");
            cylinder.Radius =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            cylinder.Height = Convert.ToDouble(Console.ReadLine());
            
            cylinder.Process();
            cylinder.Result();
        }
    }
}