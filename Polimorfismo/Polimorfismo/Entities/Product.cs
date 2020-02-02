using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Priece { get; set; }

        public Product()
        {
        }
        public Product(string name, double priece)
        {
            Name = name;
            Priece = priece;
        }
        public virtual string PriceTag()
        {
            return Name+" $ "+Priece.ToString("f2");
        }
    }
}
