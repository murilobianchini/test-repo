using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.assukar.engine
{
    public class Engine
    {
        public string test;

        public Engine(string text)
        {
            this.test = text;
            text = "";
        }
    }
}