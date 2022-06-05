using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Car
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Year { get; set; }
        public string Engine { get; set; }
        public Image images { get; set; }
       // public global:: Resources MyProperty { get; set; }

        public Car(string model,string vendor,string year,string engine,Image image)
        {
            Model = model; Vendor = vendor; Year = year; Engine = engine; images = image; 
        }
    }
}
