using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class ValuablePackage : Package,IValuable
    {
        private int _value;
        public int Value
        {
            get => _value;
            set => _value = value;
        }
        public ValuablePackage(string recipient, string sender, int weight, int value,bool registred   ) : base(recipient, sender, weight, registred )
        {
            Value = value;
            Price += value / 10;
        }

        public ValuablePackage(string recipient, string sender, int weight, int value) : base(recipient, sender, weight)
        {
            Value = value;
            Price += value / 10;
        }

        public override string ToString()
        {
            return "V" + base.ToString() + " Value:" + Value;
        }
    }
}
