using System;

namespace SuperPuperApplication
{
    public class Tester : Employee
    {
        public Tester(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{Name}: It's a bug!");
        }
    }
}
