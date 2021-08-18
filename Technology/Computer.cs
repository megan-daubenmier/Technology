using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public string Name;
        public string Owner { get; set; }

        public readonly int YearMade;
        public double Storage { get; }
        public string OperatingSystem { get; set; }

        public Computer(string name, string owner, int year, double numGB, string operatingSystem)
        {
            Name = name;
            Owner = owner;
            YearMade = year;
            Storage = numGB;
            OperatingSystem = operatingSystem;
        }

        public void Sell(string newOwner)
        {
            Owner = newOwner;
        }

        public void Update(string operatingSystem)
        {
            OperatingSystem = operatingSystem;
        }
    }
}
