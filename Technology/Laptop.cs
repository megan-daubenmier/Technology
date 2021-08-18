using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public string HarddriveType { get; set; }
        public List<string> Software = new List<string>();

        public Laptop(string name, string owner, int year, double numGB, string operatingSystem, string harddriveType) : base(name, owner, year, numGB, operatingSystem)
        {
            HarddriveType = harddriveType;
        }

        public bool installSoftware(string software)
        {
            if (!Software.Contains(software))
            {
                Software.Add(software);
                return true;
            }
            return false;
        }
    }
}
