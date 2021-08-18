using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public List<string> Applications = new List<string>();

        public SmartPhone(string name, string owner, int year, double numGB, string operatingSystem) : base(name, owner, year, numGB, operatingSystem)
        {
        }
        public bool downloadApp(string app)
        {
            if (!Applications.Contains(app))
            {
                Applications.Add(app);
                return true;
            }
            return false;
        }
    }
}
