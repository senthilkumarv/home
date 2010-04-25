namespace TestSuiteGenerator
{
    partial class StaticCheck
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtMaxScores = new System.Windows.Forms.TextBox();
            this.dgVars = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgStmts = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dgExceptions = new System.Windows.Forms.DataGridView();
            this.colType1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStmts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExceptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Scores";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(137, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(146, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // txtMaxScores
            // 
            this.txtMaxScores.Location = new System.Drawing.Point(358, 12);
            this.txtMaxScores.Name = "txtMaxScores";
            this.txtMaxScores.Size = new System.Drawing.Size(132, 20);
            this.txtMaxScores.TabIndex = 3;
            // 
            // dgVars
            // 
            this.dgVars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDataType,
            this.colScore,
            this.colErr});
            this.dgVars.Location = new System.Drawing.Point(62, 74);
            this.dgVars.Name = "dgVars";
            this.dgVars.Size = new System.Drawing.Size(443, 111);
            this.dgVars.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colDataType
            // 
            this.colDataType.HeaderText = "DataType";
            this.colDataType.Items.AddRange(new object[] {
            "VARCHAR2",
            "NUMBER",
            "DATE"});
            this.colDataType.Name = "colDataType";
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            // 
            // colErr
            // 
            this.colErr.HeaderText = "Error Message";
            this.colErr.Name = "colErr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Variables";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exceptions";
            // 
            // dgStmts
            // 
            this.dgStmts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStmts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colScore1,
            this.colErrMsg});
            this.dgStmts.Location = new System.Drawing.Point(112, 230);
            this.dgStmts.Name = "dgStmts";
            this.dgStmts.Size = new System.Drawing.Size(343, 134);
            this.dgStmts.TabIndex = 7;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // colScore1
            // 
            this.colScore1.HeaderText = "Score";
            this.colScore1.Name = "colScore1";
            // 
            // colErrMsg
            // 
            this.colErrMsg.HeaderText = "Error Message Text";
            this.colErrMsg.Name = "colErrMsg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Statement";
            // 
            // dgExceptions
            // 
            this.dgExceptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExceptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType1,
            this.colCount,
            this.colStatement,
            this.colScore2,
            this.colErr2});
            this.dgExceptions.Location = new System.Drawing.Point(15, 427);
            this.dgExceptions.Name = "dgExceptions";
            this.dgExceptions.Size = new System.Drawing.Size(548, 150);
            this.dgExceptions.TabIndex = 9;
            // 
            // colType1
            // 
            this.colType1.HeaderText = "Type";
            this.colType1.Items.AddRange(new object[] {
            "Declarations",
            "Others"});
            this.colType1.Name = "colType1";
            // 
            // colCount
            // 
            this.colCount.HeaderText = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatement
            // 
            this.colStatement.HeaderText = "Statement";
            this.colStatement.Name = "colStatement";
            this.colStatement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScore2
            // 
            this.colScore2.HeaderText = "Score";
            this.colScore2.Name = "colScore2";
            // 
            // colErr2
            // 
            this.colErr2.HeaderText = "Error Message Text";
            this.colErr2.Name = "colErr2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 599);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Static Check";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StaticCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 649);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgExceptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgStmts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgVars);
            this.Controls.Add(this.txtMaxScores);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaticCheck";
            this.Text = "StaticCheck";
            ((System.ComponentModel.ISupportInitialize)(this.dgVars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStmts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExceptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtMaxScores;
        private System.Windows.Forms.DataGridView dgVars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgStmts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgExceptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErr;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErr2;
    }
}