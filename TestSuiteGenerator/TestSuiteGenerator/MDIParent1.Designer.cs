namespace TestSuiteGenerator
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Table Check");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Static Check");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Query");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Messages");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("TestCases");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("TestSuite", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            this.tableCheckMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticCheckMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStaticCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCleanupQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addQueryTestCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPLSQLTestCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.generateXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.testSuite = new System.Windows.Forms.TreeView();
            this.saveXML = new System.Windows.Forms.SaveFileDialog();
            this.tableCheckMenu.SuspendLayout();
            this.staticCheckMenu.SuspendLayout();
            this.setupMenu.SuspendLayout();
            this.messagesMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCheckMenu
            // 
            this.tableCheckMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem});
            this.tableCheckMenu.Name = "contextMenuStrip1";
            this.tableCheckMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addTableToolStripMenuItem.Text = "Add Table";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.addTableToolStripMenuItem_Click);
            // 
            // staticCheckMenu
            // 
            this.staticCheckMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaticCheckToolStripMenuItem});
            this.staticCheckMenu.Name = "staticCheckMenu";
            this.staticCheckMenu.Size = new System.Drawing.Size(165, 26);
            // 
            // addStaticCheckToolStripMenuItem
            // 
            this.addStaticCheckToolStripMenuItem.Name = "addStaticCheckToolStripMenuItem";
            this.addStaticCheckToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addStaticCheckToolStripMenuItem.Text = "Add Static Check";
            this.addStaticCheckToolStripMenuItem.Click += new System.EventHandler(this.addStaticCheckToolStripMenuItem_Click);
            // 
            // setupMenu
            // 
            this.setupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSetupToolStripMenuItem,
            this.addCleanupQueryToolStripMenuItem});
            this.setupMenu.Name = "contextMenuStrip1";
            this.setupMenu.Size = new System.Drawing.Size(179, 48);
            // 
            // addSetupToolStripMenuItem
            // 
            this.addSetupToolStripMenuItem.Name = "addSetupToolStripMenuItem";
            this.addSetupToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addSetupToolStripMenuItem.Text = "Add Setup Query";
            this.addSetupToolStripMenuItem.Click += new System.EventHandler(this.addSetupToolStripMenuItem_Click);
            // 
            // addCleanupQueryToolStripMenuItem
            // 
            this.addCleanupQueryToolStripMenuItem.Name = "addCleanupQueryToolStripMenuItem";
            this.addCleanupQueryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addCleanupQueryToolStripMenuItem.Text = "Add Cleanup Query";
            this.addCleanupQueryToolStripMenuItem.Click += new System.EventHandler(this.addCleanupQueryToolStripMenuItem_Click);
            // 
            // messagesMenu
            // 
            this.messagesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMessageToolStripMenuItem});
            this.messagesMenu.Name = "messagesMenu";
            this.messagesMenu.Size = new System.Drawing.Size(146, 26);
            // 
            // addMessageToolStripMenuItem
            // 
            this.addMessageToolStripMenuItem.Name = "addMessageToolStripMenuItem";
            this.addMessageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addMessageToolStripMenuItem.Text = "Add Message";
            this.addMessageToolStripMenuItem.Click += new System.EventHandler(this.addMessageToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQueryTestCaseToolStripMenuItem,
            this.addPLSQLTestCaseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 70);
            // 
            // addQueryTestCaseToolStripMenuItem
            // 
            this.addQueryTestCaseToolStripMenuItem.Name = "addQueryTestCaseToolStripMenuItem";
            this.addQueryTestCaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addQueryTestCaseToolStripMenuItem.Text = "Add Query TestCase";
            this.addQueryTestCaseToolStripMenuItem.Click += new System.EventHandler(this.addQueryTestCaseToolStripMenuItem_Click);
            // 
            // addPLSQLTestCaseToolStripMenuItem
            // 
            this.addPLSQLTestCaseToolStripMenuItem.Name = "addPLSQLTestCaseToolStripMenuItem";
            this.addPLSQLTestCaseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.addPLSQLTestCaseToolStripMenuItem.Text = "Add PL/SQL TestCase";
            this.addPLSQLTestCaseToolStripMenuItem.Click += new System.EventHandler(this.addPLSQLTestCaseToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem1.Text = "Add Table";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem2.Text = "Add Static Check";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem3.Text = "Add Setup Queries";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem4.Text = "Add Cleanup Queries";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem6.Text = "Add Messages";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem5.Text = "Add Query TestCase";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem7.Text = "Add PL/SQL TestCase";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateXMLToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(48, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // generateXMLToolStripMenuItem
            // 
            this.generateXMLToolStripMenuItem.Name = "generateXMLToolStripMenuItem";
            this.generateXMLToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.generateXMLToolStripMenuItem.Text = "Generate XML";
            this.generateXMLToolStripMenuItem.Click += new System.EventHandler(this.generateXMLToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.testSuite);
            this.splitContainer1.Size = new System.Drawing.Size(632, 407);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 4;
            // 
            // testSuite
            // 
            this.testSuite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSuite.Location = new System.Drawing.Point(0, 0);
            this.testSuite.Name = "testSuite";
            treeNode31.ContextMenuStrip = this.tableCheckMenu;
            treeNode31.Name = "tableCheck";
            treeNode31.Text = "Table Check";
            treeNode32.ContextMenuStrip = this.staticCheckMenu;
            treeNode32.Name = "staticCheck";
            treeNode32.Text = "Static Check";
            treeNode33.ContextMenuStrip = this.setupMenu;
            treeNode33.Name = "setup";
            treeNode33.Text = "Query";
            treeNode34.ContextMenuStrip = this.messagesMenu;
            treeNode34.Name = "messages";
            treeNode34.Text = "Messages";
            treeNode35.ContextMenuStrip = this.contextMenuStrip1;
            treeNode35.Name = "testCases";
            treeNode35.Text = "TestCases";
            treeNode36.Checked = true;
            treeNode36.Name = "testSuite";
            treeNode36.Text = "TestSuite";
            this.testSuite.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode36});
            this.testSuite.Size = new System.Drawing.Size(210, 407);
            this.testSuite.TabIndex = 3;
            this.testSuite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.testSuite_MouseClick);
            // 
            // saveXML
            // 
            this.saveXML.DefaultExt = "xml";
            this.saveXML.Filter = "\"XML files|*.xml\"";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "TestSuite Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.tableCheckMenu.ResumeLayout(false);
            this.staticCheckMenu.ResumeLayout(false);
            this.setupMenu.ResumeLayout(false);
            this.messagesMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView testSuite;
        private System.Windows.Forms.ContextMenuStrip tableCheckMenu;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip staticCheckMenu;
        private System.Windows.Forms.ToolStripMenuItem addStaticCheckToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip messagesMenu;
        private System.Windows.Forms.ToolStripMenuItem addMessageToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip setupMenu;
        private System.Windows.Forms.ToolStripMenuItem addSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCleanupQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateXMLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addQueryTestCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPLSQLTestCaseToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveXML;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}



