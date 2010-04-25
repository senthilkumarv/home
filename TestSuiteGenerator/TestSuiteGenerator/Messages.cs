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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            string msgColl = tbMsgs.Text;
            string[] msgsTxt = msgColl.Split('\n');

            Message []msgs = new Message[msgsTxt.Length];
            foreach (string str in msgsTxt)
            {                
                if (!str.Equals(""))
                {
                    msgs[cnt] = new Message();
                    msgs[cnt].Text = str;
                    cnt++;
                }
            }
            TestSuiteDB.saveMessages(msgs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
