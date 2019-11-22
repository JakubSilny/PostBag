using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class Package : Consignment
    {
        protected bool Registered = false;
        protected string Sender;
        protected int Weight;

        public Package(string recipient, string sender, int weight, bool registred) : base(100 + weight + (registred ? 10 : 0), recipient)
        {
            Registered = registred;
            Sender = sender;
            Weight = weight;
        }

        public Package(string recipient, string sender, int weight) : base(100 + weight, recipient)
        {
            Sender = sender;
            Weight = weight;
        }

        public override string ToString()
        {
            if (Registered == true)
            {
                return "PCK" + base.ToString() + "REG";

            }
            else
            {
                return "PCK" + base.ToString();
            }
        }
    }
}
