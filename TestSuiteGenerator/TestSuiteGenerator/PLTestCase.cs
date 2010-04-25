using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class PLTestCase
    {
        string maxScore;

        public string MaxScore
        {
            get { return maxScore; }
            set { maxScore = value; }
        }
        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        InputTestCasePL[] inputs;

        internal InputTestCasePL[] Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }
        OutputTestCasePL[] outputs;

        internal OutputTestCasePL[] Outputs
        {
            get { return outputs; }
            set { outputs = value; }
        }

        public override string ToString()
        {
            string str = "";
            str = "<testcase maxscore = \"" + maxScore + "\">\n";
            str += "<execute type=\"plsql\" filename=\"" + fileName + "\">\n";
            str += "<input>\n";
            if (inputs != null)
            {
                foreach (InputTestCasePL ip in inputs)
                {
                    if (ip != null)
                        str += ip.ToString();
                }
            }
            str += "</input>\n";
            str += "<output>\n";
            if (outputs != null)
            {
                foreach (OutputTestCasePL op in outputs)
                {
                    if (op != null)
                        str += op.ToString();
                }
            }
            str += "</output>\n";
            str += "</execute>\n";
            str += "</testcase>\n";
            return str;
        }
    }
}
