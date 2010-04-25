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
    public partial class TCGenerator : Form
    {
        public TCGenerator()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLTestCase ptc = new PLTestCase();
            ptc.FileName = txtFileName.Text;
            ptc.MaxScore = spnMaxScore.Value + "";
            InputTestCasePL[] itcp = new InputTestCasePL[dgInput.Rows.Count];
            int cnt = 0;
            foreach (DataGridViewRow row in dgInput.Rows)
            {
                string name = row.Cells[0].Value + "";
                if (!name.Equals(""))
                {
                    itcp[cnt] = new InputTestCasePL();
                    itcp[cnt].Name = name;
                    itcp[cnt].Type = row.Cells[1].Value + "";
                    itcp[cnt].Value = row.Cells[2].Value + "";
                    cnt++;
                }
            }
            ptc.Inputs = itcp;
            cnt = 0;
            OutputTestCasePL[] otcp = new OutputTestCasePL[dgOutput.Rows.Count];
            foreach (DataGridViewRow dgvr in dgOutput.Rows)
            {
                string type = dgvr.Cells[0].Value + "";
                if (type.Equals("")) continue;
                otcp[cnt] = new OutputTestCasePL();
                otcp[cnt].Type = type;
                otcp[cnt].DataType = dgvr.Cells[1].Value + "";
                otcp[cnt].Score = dgvr.Cells[2].Value + "";
                otcp[cnt].ErrMsg = dgvr.Cells[3].Value + "";
                otcp[cnt].Query = dgvr.Cells[4].Value + "";
                otcp[cnt].ExpValue = dgvr.Cells[5].Value + "";

                cnt++;
            }
            ptc.Outputs = otcp;
            ptc.Type = "plsql";
            
            Query []setup = new Query[tbSetup.Lines.Length];
            cnt =0;
            string[] setupstr = tbSetup.Lines;
            if (setupstr != null)
            {
                if (setupstr.Length > 0)
                {
                    foreach (string str in setupstr)
                    {
                        if(str != null)
                            setup[cnt++] = new Query(str);
                    }
                }
            }
            ptc.Setup = setup;
            Query []cleanup = new Query[tbCleanup.Lines.Length];
            cnt =0;
            string[] cleanupstr = tbCleanup.Lines;
            if (cleanupstr != null)
            {
                if (cleanupstr.Length > 0)
                {
                    foreach (string str in cleanupstr)
                    {
                        if(str != null)
                            cleanup[cnt++] = new Query(str);
                    }
                }
            }
            ptc.Cleanup = cleanup;
            TestSuiteDB.savePLTestCase(ptc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
