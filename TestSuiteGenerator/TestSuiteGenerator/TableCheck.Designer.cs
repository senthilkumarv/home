namespace TestSuiteGenerator
{
    partial class TableCheck
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
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spnScore = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colConstraint = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(98, 21);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(133, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // spnScore
            // 
            this.spnScore.Location = new System.Drawing.Point(292, 21);
            this.spnScore.Name = "spnScore";
            this.spnScore.Size = new System.Drawing.Size(76, 20);
            this.spnScore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table Name";
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colConstraint});
            this.dgTable.Location = new System.Drawing.Point(12, 62);
            this.dgTable.Name = "dgTable";
            this.dgTable.Size = new System.Drawing.Size(375, 194);
            this.dgTable.TabIndex = 4;
            // 
            // colName
            // 
            this.colName.HeaderText = "Column Name";
            this.colName.Name = "colName";
            // 
            // colType
            // 
            this.colType.HeaderText = "DataType";
            this.colType.Items.AddRange(new object[] {
            "VARCHAR2",
            "NUMBER",
            "DATE"});
            this.colType.Name = "colType";
            // 
            // colConstraint
            // 
            this.colConstraint.HeaderText = "Constraint";
            this.colConstraint.Items.AddRange(new object[] {
            "Primary Key",
            "Refrence Key"});
            this.colConstraint.Name = "colConstraint";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(53, 270);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(117, 24);
            this.btnAddTable.TabIndex = 5;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TableCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 307);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.dgTable);
            this.Controls.Add(this.spnScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label3);
            this.Name = "TableCheck";
            this.Text = "TableCheck";
            this.Load += new System.EventHandler(this.TableCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewComboBoxColumn colConstraint;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnCancel;

    }
}