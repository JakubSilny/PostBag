using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class PostalOrder : IValuable
    {
        string Recipient;

        private int _value;

        public PostalOrder(string recipient,int value)
        {
            Value = value;
            Recipient = recipient;
        }

        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public override string ToString()
        {
            return "MON> To:" + Recipient +" Value:"+ Value;
        }
    }
}
