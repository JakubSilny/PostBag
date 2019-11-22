using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    class Letter : Consignment
    {
        bool Registered;
        string Sender;

        public Letter(global::System.Boolean registered, global::System.String sender)
        {
            Registered = registered;
            Sender = sender;
        }

        public override string Tostring()
        {
            string str = "";

            str += "LET> " + "To:" ;


            return str;
        }
    }
}
