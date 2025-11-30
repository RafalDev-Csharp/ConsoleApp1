using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NewClassCalculate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CalculateArea(double radius) => Math.PI * radius * radius;
        public string City { get; set; }
        public string Weatherty { get; set; }
        public string ZipCode { get; set; }
    }
}
