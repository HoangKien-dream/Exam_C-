using System;

namespace Exam
{
    public class  Lion: Pet
    {
        public override void SetMe(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}