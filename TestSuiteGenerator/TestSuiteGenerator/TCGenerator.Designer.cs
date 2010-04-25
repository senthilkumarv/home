namespace TestSuiteGenerator
{
    partial class TCGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.spnMaxScore = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.dgOutput = new System.Windows.Forms.DataGridView();
            this.chkType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chkDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chkScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgkErrMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkExpValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInput = new System.Windows.Forms.DataGridView();
            this.ipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ipValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxScore)).BeginInit();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Score";
            // 
            // spnMaxScore
            // 
            this.spnMaxScore.Location = new System.Drawing.Point(210, 27);
            this.spnMaxScore.Name = "spnMaxScore";
            this.spnMaxScore.Size = new System.Drawing.Size(58, 20);
            this.spnMaxScore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(354, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(158, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.dgOutput);
            this.gbInput.Location = new System.Drawing.Point(13, 68);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(619, 199);
            this.gbInput.TabIndex = 6;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Output";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.dgInput);
            this.gbOutput.Location = new System.Drawing.Point(12, 284);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(620, 180);
            this.gbOutput.TabIndex = 7;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Input";
            // 
            // dgOutput
            // 
            this.dgOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkType,
            this.chkDataType,
            this.chkScore,
            this.cgkErrMsg,
            this.chkQuery,
            this.chkExpValue});
            this.dgOutput.Location = new System.Drawing.Point(6, 19);
            this.dgOutput.Name = "dgOutput";
            this.dgOutput.Size = new System.Drawing.Size(607, 173);
            this.dgOutput.TabIndex = 0;
            // 
            // chkType
            // 
            this.chkType.HeaderText = "Type";
            this.chkType.Items.AddRange(new object[] {
            "query",
            "dbmsoutput"});
            this.chkType.Name = "chkType";
            this.chkType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chkDataType
            // 
            this.chkDataType.HeaderText = "Data Type";
            this.chkDataType.Items.AddRange(new object[] {
            "int",
            "string"});
            this.chkDataType.Name = "chkDataType";
            this.chkDataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chkScore
            // 
            this.chkScore.HeaderText = "Score";
            this.chkScore.Name = "chkScore";
            // 
            // cgkErrMsg
            // 
            this.cgkErrMsg.HeaderText = "Error Message Text";
            this.cgkErrMsg.Name = "cgkErrMsg";
            // 
            // chkQuery
            // 
            this.chkQuery.HeaderText = "Query";
            this.chkQuery.Name = "chkQuery";
            // 
            // chkExpValue
            // 
            this.chkExpValue.HeaderText = "Exp Value";
            this.chkExpValue.Name = "chkExpValue";
            // 
            // dgInput
            // 
            this.dgInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipName,
            this.ipType,
            this.ipValue});
            this.dgInput.Location = new System.Drawing.Point(7, 20);
            this.dgInput.Name = "dgInput";
            this.dgInput.Size = new System.Drawing.Size(607, 150);
            this.dgInput.TabIndex = 0;
            // 
            // ipName
            // 
            this.ipName.HeaderText = "Name";
            this.ipName.Name = "ipName";
            // 
            // ipType
            // 
            this.ipType.HeaderText = "Type";
            this.ipType.Items.AddRange(new object[] {
            "VARCHAR2",
            "NUMBER",
            "DATE"});
            this.ipType.Name = "ipType";
            // 
            // ipValue
            // 
            this.ipValue.HeaderText = "Value";
            this.ipValue.Name = "ipValue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add PL/SQL TestCase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TCGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spnMaxScore);
            this.Controls.Add(this.label1);
            this.Name = "TCGenerator";
            this.Text = "TCGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxScore)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spnMaxScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.DataGridView dgOutput;
        private System.Windows.Forms.DataGridViewComboBoxColumn chkType;
        private System.Windows.Forms.DataGridViewComboBoxColumn chkDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgkErrMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkExpValue;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.DataGridView dgInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}