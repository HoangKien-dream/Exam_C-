using System;

namespace Exam
{
    public  abstract class Pet
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public void Show()
        {
            Console.WriteLine("Name: {0}, Weight: {1}",Name, Weight);
        }

        public abstract void SetMe(string name, int height);
    }
}