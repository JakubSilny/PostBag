using System;
using System.Collections.Generic;
using System.Text;

namespace PostBag
{
    interface IValuable 
    {
        string ToString();
        public int Value
        {
            get;
            set;
        }
    }
}
