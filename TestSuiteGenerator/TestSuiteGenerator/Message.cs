using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Message
    {
        string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public override string ToString()
        {
            return "<message>" + this.text + "</message>\n";
        }
    }
}
