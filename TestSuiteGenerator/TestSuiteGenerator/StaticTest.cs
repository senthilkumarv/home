using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class StaticTest
    {
        string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        int maxScores;

        public int MaxScores
        {
            get { return maxScores; }
            set { maxScores = value; }
        }
        Variable[] vars;

        internal Variable[] Vars
        {
            get { return vars; }
            set { vars = value; }
        }
        Statement[] stmts;

        internal Statement[] Stmts
        {
            get { return stmts; }
            set { stmts = value; }
        }
        TestSuiteGenerator.Exceptions[] ex;

        internal TestSuiteGenerator.Exceptions[] Ex
        {
            get { return ex; }
            set { ex = value; }
        }

        public override string ToString()
        {
            string str = "<staticcheck filename=\"" + this.FileName + "\" maxscores=\"" + this.MaxScores + "\">\n";
            foreach (Variable var in vars)
            {
                if (var == null) continue;
                str += var.ToString();
            }
            foreach (Statement stmt in stmts)
            {
                if (stmt == null) continue;
                str += stmt.ToString();
            }
            foreach (Exceptions e in Ex)
            {
                if (e == null) continue;
                str += e.ToString();
            }
            str += "</staticcheck>\n";
            return str;
        }
    }
}
