using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class Letter : Consignment
    {
        protected bool Registered = false;
        protected string Sender;

        public Letter(string recipient,string sender, bool registered) : base(10 + (registered?10:0), recipient)
        {
            Registered = registered;
            Sender = sender;
        }

        public Letter(string recipient, string sender) : base(10, recipient)
        {
            Sender = sender;
        }

        public override string ToString()
        {
            if (Registered == true)
            {
                return "LET" + base.ToString() + "REG";

            }
            else
            {
                return "LET" + base.ToString() ;
            }

        }
    }
}
