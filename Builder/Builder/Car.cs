using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public DateTime ProductionYear { get; set; }
         
        public void PresentCar()
        {
            Console.WriteLine(Brand + " " + Color + " " + Type + " " + ProductionYear);
        }
    }
}
