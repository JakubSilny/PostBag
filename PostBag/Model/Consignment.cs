using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    abstract class Consignment
    {
        protected int Price;
        protected string Recipient;


        protected Consignment(int price,string recipient)
        {
            Price = price;
            Recipient = recipient;
        }

        public override string ToString()
        {
            return "> To:"+Recipient + " Price:" + Price;
        }
    }
}
