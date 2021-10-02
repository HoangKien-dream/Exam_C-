using System;
using Exam;

namespace Exam2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.SetMe("lion", 100);
            lion.Show();
            Tiger tiger = new Tiger();
            tiger.SetMe("tiger", 200);
            tiger.Show();
        }
    }
}