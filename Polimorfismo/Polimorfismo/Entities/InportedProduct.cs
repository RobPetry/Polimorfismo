using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class InportedProduct : Product
    {
        public double CustomFee { get; set; }

        public InportedProduct()
        {
        }

        public InportedProduct(string name, double priece,double customFee)
           : base(name,priece)
        {
            CustomFee = customFee;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPriece():f2} (custom fee: {CustomFee:f2})";
        }
        public double TotalPriece()
        {
            return CustomFee + Priece; 
        }
    }
}
