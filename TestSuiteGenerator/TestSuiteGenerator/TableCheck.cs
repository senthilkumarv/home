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
    public partial class TableCheck : Form
    {
        public TableCheck()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TableName = txtTableName.Text;
            table.MaxScores = (int)spnScore.Value;

            TableColumn[] cols = new TableColumn[dgTable.Rows.Count];
            int cnt = 0;
            foreach (DataGridViewRow dgvr in dgTable.Rows)
            {
                String name = dgvr.Cells[0].Value + "";
                if (!name.Equals(""))
                {
                    cols[cnt] = new TableColumn();
                    cols[cnt].ColName = name + "";
                    cols[cnt].DataType = dgvr.Cells[1].Value + "";
                    cols[cnt].Contraint = dgvr.Cells[2].Value + "";
                    cnt++;
                }
            }

            table.Cols = cols;
            TestSuiteDB.saveTable(table);
            
        }

        private void TableCheck_Load(object sender, EventArgs e)
        {
            spnScore.Value = 30;
        }

    }
}
