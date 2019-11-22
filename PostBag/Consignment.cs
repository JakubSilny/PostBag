using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    abstract class Consignment
    {
        protected int price;
        protected string Recipient;

        protected Consignment(global::System.Int32 price, global::System.String recipient)
        {
            this.price = price;
            Recipient = recipient;
        }

        public abstract ToString()
        {

        }


    }
}
