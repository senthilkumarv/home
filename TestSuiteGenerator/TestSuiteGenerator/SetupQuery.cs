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
    public partial class CleanupQueries : Form
    {
        public CleanupQueries()
        {
            InitializeComponent();
        }

        string type = "Setup";

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        

        private void button2_Click(object sender, EventArgs e)
        {

            int cnt = 0;
            
            string[] qs = tbQueries.Text.Split('\n');
            Query[] queries = new Query[qs.Length];
            foreach (string q in qs)
            {
                if (!q.Equals(""))
                {
                    queries[cnt] = new Query();
                    queries[cnt].Text = q;
                    queries[cnt].Type = type;
                    cnt++;
                }
            }
            if (Type.Equals("Setup"))
                TestSuiteDB.saveSetupQueries(queries);
            else
                TestSuiteDB.saveCleanupQueries(queries);
        }

        private void CleanupQueries_Load(object sender, EventArgs e)
        {
            label1.Text = type + " Queries";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

