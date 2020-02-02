
using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class UsedProduct:Product
    {
        public DateTime Date { get; set; }

        public UsedProduct(string name, double priece,DateTime date)
        : base(name, priece)
        {
            Date = date;
        }
        public override string PriceTag()
        {
            return $"{Name} (used) $ {Priece:f2} (Manufactured date: {Date:dd/MM/yyyy})";
        }
    }
}
