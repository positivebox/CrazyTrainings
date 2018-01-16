using System;

namespace SuperPuperApplication
{
    public abstract class Employee
    {
        private readonly string _name;
        private const string CompanyName = "SoftServe";

        public string Name => _name;

        protected Employee(string name)
        {
            _name = name;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, I'm {_name}");
        }
        public abstract void Work();

        public static void DisplayCompanyInfo()
        {
            Console.WriteLine(CompanyName);
        }
    }
}
