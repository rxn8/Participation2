using System;
using System.Collections.Generic;
using System.Text;

namespace Participation2
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string aisle { get; set; }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
        }

        public override string ToString()
        {
            return $"{Manufacturer}-{Name}";
        }
        public string GetAisle()
        {
            return aisle = $"{char.ToUpper(Manufacturer[0])}{Convert.ToString(Price).Replace(".", "")}";
        }
    }
}
