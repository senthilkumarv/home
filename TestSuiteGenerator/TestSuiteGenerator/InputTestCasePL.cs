using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class InputTestCasePL
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public override string ToString()
        {
            string str = "<param name=\"" + this.Name + "\" type=\"" + this.Type + "\" value=\"" + this.Value + "\"></param>\n";
            return str;
        }
    }
}
