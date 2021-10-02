using System;

namespace Exam
{
    public class Cylinder
    {

       public double Radius { get; set; }
        public  double Height { get; set; }

        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
         public double Total { get; set; }
       public double Volume { get; set; }
        
        public void Process()
        { 
             BaseArea =  Radius * Radius * Math.PI;
             LateralArea = 2 * Math.PI * Radius * Height;
             Total = 2 * Math.PI * Radius * (Height + Radius);
             Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: {0}, Height: {1}", Radius,Height);
            Console.WriteLine("Base: {0} : Lateral: {1} : Total: {2} : Volume: {3}",BaseArea, LateralArea, Total,Volume);
        }
    }
}