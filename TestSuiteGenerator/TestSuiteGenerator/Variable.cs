using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Variable
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string dataType;

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        string errMsg;

        public string ErrMsg
        {
            get { return errMsg; }
            set { errMsg = value; }
        }

        public override string ToString()
        {
            string str = "<variable name=\"" + this.Name + "\" type=\"" + this.DataType +"\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\" />\n";
            return str;
        }
    }
}
