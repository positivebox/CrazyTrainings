using System;

namespace SuperPuperApplication
{
    public class Developer : Employee
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{Name}: It's a feature!");
        }
    }
}
