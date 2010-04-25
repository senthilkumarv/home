using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Exceptions
    {
        Check[] checks;

        internal Check[] Checks
        {
            get { return checks; }
            set { checks = value; }
        }

        public override string ToString()
        {
            string str = "<exception>\n";
            foreach (Check chk in checks)
            {
                if (chk != null)
                {
                    str += chk.ToString();
                }
            }
            str += "</exception>\n";
            return str;
        }
    }

    class Check
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string count;

        public string Count
        {
            get { return count; }
            set { count = value; }
        }
        string statement;

        public string Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        string score;

        public string Score
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
            string str;
            if (this.Type.Equals("Declaration"))
                str = "<check type=\"declaration\" count=\"" + this.Count + "\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\"/>\n";
            else
                str = "<check type=\"others\" statement=\"" + this.Statement + "\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\"/>\n";
            return str;
        }
    }
}
