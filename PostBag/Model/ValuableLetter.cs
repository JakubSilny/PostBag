using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class ValuableLetter : Letter, IValuable
    {
        private int _value;
        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public ValuableLetter(string recipient,string sender  ,int value,bool registered) : base(   recipient, sender, registered)
        {
            Value = value;
            Price += value / 10;
        }

        public ValuableLetter(string recipient, string sender, int value) : base(recipient,sender)
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
