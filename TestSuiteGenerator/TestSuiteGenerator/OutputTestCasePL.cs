using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class OutputTestCasePL
    {
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string dataType;

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
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
        string query;

        public string Query
        {
            get { return query; }
            set { query = value; }
        }
        string expValue;

        public string ExpValue
        {
            get { return expValue; }
            set { expValue = value; }
        }

        public override string ToString()
        {
            string str = "";

            if (this.Type.Equals("dbmsoutput"))
                str = "<check type=\"dbmsoutput\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\" expvalue=\"" + this.ExpValue + "\" />\n";
            else if (this.Type.Equals("query"))
            {
                str = "<check type=\"query\" datatype=\"" + this.DataType + "\" score=\"" + this.Score + "\" errormessage=\"" + this.ErrMsg + "\" expvalue=\"" + this.ExpValue + "\">\n";
                str += this.Query + "\n";
                str += "</check>";
            }
            return str;

        }
    }
}
