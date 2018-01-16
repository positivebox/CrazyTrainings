using System;

namespace SuperPuperApplication
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("I'm your manager.");
        }

        public override void Work()
        {
            Console.WriteLine("Usem privet!");
        }
    }
}
