﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_ViggiCoin_v2._0
{
    //Wrapper usato per ritornare valori dalla funzione CPeers.DoRequest()
    class ArgumentWrapper<T>
    {
        public T Value;

        public ArgumentWrapper()
        { }

        public ArgumentWrapper(T Value)
        {
            this.Value = Value;
        }
    }
}
