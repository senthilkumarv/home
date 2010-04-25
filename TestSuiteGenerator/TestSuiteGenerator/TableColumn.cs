using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSuiteGenerator
{
    class TableColumn
    {
        string colName;

        public string ColName
        {
            get { return colName; }
            set { colName = value; }
        }
        string dataType;

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        string contraint;

        public string Contraint
        {
            get { return contraint; }
            set { contraint = value; }
        }

        public override String ToString()
        {
            String str = "";
            if(this.contraint.Equals(""))
                str = "<param colname=\"" + this.ColName + "\" datatype=\"" + this.DataType + "\" />\n";
            else
                str = "<param colname=\"" + this.ColName + "\" datatype=\"" + this.DataType + "\" constraint=\"" + this.Contraint + "\"/>\n";
            return str;
        }
    }
}
