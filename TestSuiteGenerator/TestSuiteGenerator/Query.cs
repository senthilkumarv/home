using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Query
    {
        public Query()
        {
        }

        public Query(string str)
        {
            this.text = str;
        }

        string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return "<query>" + text + "</query>\n";
        }

    }
}
