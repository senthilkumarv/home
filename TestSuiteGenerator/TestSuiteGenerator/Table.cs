using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class Table
    {
        string tableName;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        
        int maxScores;

        public int MaxScores
        {
            get { return maxScores; }
            set { maxScores = value; }
        }
        
        TableColumn[] cols;

        public TableColumn[] Cols
        {
            get { return cols; }
            set { cols = value; }
        }

        public override String ToString()
        {
            String str;
            str = "<table name=\"" + this.TableName + "\" score=\"" + this.MaxScores + "\">\n";
            foreach (TableColumn tc in this.Cols)
            {
                if (tc != null)
                {
                    str += tc.ToString();
                }
            }
            str += "</table>\n";
            return str;
        }
    }
}
