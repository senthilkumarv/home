using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Statement
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
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
            string str = "<statement type=\"" + this.Type + "\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\"/>\n";
            return str;
        }
    }
}
