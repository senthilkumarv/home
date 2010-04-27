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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }
        
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            testSuite.Nodes[0].Expand();
        }

        private void clearRightPane()
        {
            foreach (Control c in splitContainer1.Panel2.Controls)
            {
                c.Hide();
                splitContainer1.Panel2.Controls.Remove(c);
            }
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            TableCheck tchk = new TableCheck();
            tchk.MdiParent = this;
            tchk.Dock = DockStyle.Fill;
            tchk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(tchk);
            tchk.Show();
        }

        private void addStaticCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            StaticCheck schk = new StaticCheck();
            schk.MdiParent = this;
            schk.Dock = DockStyle.Fill;
            schk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(schk);
            schk.Show();
        }

        private void addMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            Messages msgs = new Messages();
            msgs.MdiParent = this;
            msgs.Dock = DockStyle.Fill;
            msgs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(msgs);
            msgs.Show();
        }

        private void addSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            CleanupQueries query = new CleanupQueries();
            query.Type = "Setup";

            query.MdiParent = this;
            query.Dock = DockStyle.Fill;
            query.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(query);
            query.Show();
        }

        private void addCleanupQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            CleanupQueries query = new CleanupQueries();
            query.Type = "Cleanup";

            query.MdiParent = this;
            query.Dock = DockStyle.Fill;
            query.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(query);
            query.Show();
        }

        private void generateXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveXML.ShowDialog();
            string fileName = "";
            if (res == DialogResult.OK)
            {
                fileName = saveXML.FileName;
                TestSuiteDB.GenerateTestSuite(fileName);
            }
           

        }

        public void addTableNode()
        {
            TreeNode node = testSuite.Nodes[0].Nodes[0];
            foreach(TreeNode t in node.Nodes){
                t.Remove();
            }
            Table[] tables = TestSuiteDB.getTables();
            if (tables != null)
            {
                foreach (Table t in tables)
                {
                    if (t == null) continue;
                    node.Nodes.Add(t.TableName);
                }
            }
            node = testSuite.Nodes[0].Nodes[4];
            foreach (TreeNode t in node.Nodes)
            {
                t.Remove();
            }

            PLTestCase[] pltests = TestSuiteDB.getPLTestCases();
            int cnt = 1;
            if (pltests != null)
            {
                foreach (PLTestCase ptc in pltests)
                {
                    if (ptc == null) continue;
                    node.Nodes.Add("PL/SQL: " + cnt);
                    cnt++;
                }
            }

            QueryTestCase[] querytests = TestSuiteDB.getQueryTestCases();
            cnt = 1;
            if (querytests != null)
            {
                foreach (QueryTestCase qtc in querytests)
                {
                    if (qtc == null) continue;
                    node.Nodes.Add("Query: " + cnt);
                    cnt++;
                }
            }
        }

        private void testSuite_MouseClick(object sender, MouseEventArgs e)
        {
            this.addTableNode();
        }

        private void addQueryTestCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            QueryTestCaseFrm query = new QueryTestCaseFrm();
            query.MdiParent = this;
            query.Dock = DockStyle.Fill;
            query.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(query);
            query.Show();
        }

        private void addPLSQLTestCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearRightPane();
            TCGenerator plsql = new TCGenerator();
            plsql.MdiParent = this;
            plsql.Dock = DockStyle.Fill;
            plsql.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Add(plsql);
            plsql.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addTableToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addStaticCheckToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            addSetupToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            addCleanupQueryToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            addMessageToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            addQueryTestCaseToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            addPLSQLTestCaseToolStripMenuItem_Click(sender, e);
        }
    }
}
