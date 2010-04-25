using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestSuiteGenerator
{
    public partial class QueryTestCaseFrm : Form
    {
        public QueryTestCaseFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryTestCase qtc = new QueryTestCase();
            qtc.MaxScore = txtMaxScore.Text;
            qtc.Query = txtQuery.Text;
            qtc.FileName = txtFileName.Text;
            qtc.ErrMsg = txtErrMsg.Text;
            TestSuiteDB.saveQueryTestCase(qtc);
        }
    }
}
