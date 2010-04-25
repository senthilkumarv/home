using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class QueryTestCase
    {
        string maxScore;

        public string MaxScore
        {
            get { return maxScore; }
            set { maxScore = value; }
        }
        string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
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

        public override string ToString()
        {
            string str = "";
            str += "<testcase maxscore = \"" + maxScore + "\">\n";
            str += "<execute type=\"query\" filename=\"" + fileName + "\">\n";
            str += "<output>\n";
            str += "<check type=\"query\"  score=\"" + maxScore + "\" errormessage=\"" + errMsg + "\"  >\n";
            str += query + "\n";
            str += "</check>\n";
            str += "</output>\n";
            str += "</execute>\n";
            str += "</testcase>\n";
            return str;

        }
    }
}
