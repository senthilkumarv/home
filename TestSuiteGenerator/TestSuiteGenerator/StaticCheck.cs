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
    public partial class StaticCheck : Form
    {
        public StaticCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaticTest test = new StaticTest();

            test.FileName = txtFileName.Text;
            test.MaxScores = Int32.Parse(txtMaxScores.Text);
            Variable[] vars = new Variable[dgVars.Rows.Count];
            int cnt = 0;
            foreach (DataGridViewRow dgvr in dgVars.Rows)
            {
                string name = dgvr.Cells[0].Value + "";
                if (!name.Equals(""))
                {
                    vars[cnt] = new Variable();
                    vars[cnt].Name = name;
                    vars[cnt].DataType = dgvr.Cells[1].Value + "";
                    vars[cnt].Score = Int32.Parse(dgvr.Cells[2].Value + "");
                    vars[cnt].ErrMsg = dgvr.Cells[3].Value + "";
                    cnt++;
                }
            }
            test.Vars = vars;
            cnt = 0;
            Statement[] stmts = new Statement[dgStmts.Rows.Count];
            foreach (DataGridViewRow dgvr in dgStmts.Rows)
            {
                string type = dgvr.Cells[0].Value + "";
                if (!type.Equals(""))
                {
                    stmts[cnt] = new Statement();
                    stmts[cnt].Type = type;
                    stmts[cnt].Score = Int32.Parse(dgvr.Cells[1].Value + "");
                    stmts[cnt].ErrMsg = dgvr.Cells[2].Value + "";
                    cnt++;
                }
            }
            test.Stmts = stmts;
            Exceptions ex = new Exceptions();
            Check []checks = new Check[dgExceptions.Rows.Count];
            cnt = 0;
            foreach (DataGridViewRow dgvr in dgExceptions.Rows)
            {
                string type = dgvr.Cells[0].Value + "";
                if (!type.Equals(""))
                {
                    checks[cnt] = new Check();
                    checks[cnt].Type = type;
                    checks[cnt].Count = Int32.Parse(dgvr.Cells[1].Value + "");
                    checks[cnt].Statement = dgvr.Cells[2].Value + "";
                    checks[cnt].Score = Int32.Parse(dgvr.Cells[3].Value + "");
                    checks[cnt].ErrMsg = dgvr.Cells[4].Value + "";
                }
            }
            ex.Checks = checks;
            test.Ex = new Exceptions[] { ex };
            TestSuiteDB.saveStaticTest(test);
        }
    }
}
