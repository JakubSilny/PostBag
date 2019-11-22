using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class Postcard : Consignment
    {
        string Sender;

        public Postcard(string recipient, string sender) : base(2, recipient)
        {
            Sender = sender;
        }

        public override string ToString()
        {
            return "CAR" + base.ToString();
        }
    }
}
