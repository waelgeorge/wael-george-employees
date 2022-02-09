namespace FindPairEmpWorkedAsTeamLongest
{
    partial class FrmFindPairs
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
            this.BtnLoadCSV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpID01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csvFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadCSV
            // 
            this.BtnLoadCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadCSV.Location = new System.Drawing.Point(458, 327);
            this.BtnLoadCSV.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadCSV.Name = "BtnLoadCSV";
            this.BtnLoadCSV.Size = new System.Drawing.Size(97, 28);
            this.BtnLoadCSV.TabIndex = 2;
            this.BtnLoadCSV.Text = "Load CSV File ...";
            this.BtnLoadCSV.UseVisualStyleBackColor = true;
            this.BtnLoadCSV.Click += new System.EventHandler(this.BtnLoadCSV_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID01,
            this.EmpID02,
            this.ProjectID,
            this.DaysWorked});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 306);
            this.dataGridView1.TabIndex = 3;
            // 
            // EmpID01
            // 
            this.EmpID01.DataPropertyName = "FstEmployeeID";
            this.EmpID01.HeaderText = "Employee ID #1";
            this.EmpID01.Name = "EmpID01";
            // 
            // EmpID02
            // 
            this.EmpID02.DataPropertyName = "SecEmployeeID";
            this.EmpID02.HeaderText = "Employee ID #2";
            this.EmpID02.Name = "EmpID02";
            // 
            // ProjectID
            // 
            this.ProjectID.DataPropertyName = "ProjectID";
            this.ProjectID.HeaderText = "Project ID";
            this.ProjectID.Name = "ProjectID";
            // 
            // DaysWorked
            // 
            this.DaysWorked.DataPropertyName = "WorkedDays";
            this.DaysWorked.HeaderText = "Days Worked";
            this.DaysWorked.Name = "DaysWorked";
            // 
            // csvFileDialog
            // 
            this.csvFileDialog.DefaultExt = "*.csv";
            this.csvFileDialog.FileName = "csvFileDialog";
            this.csvFileDialog.Filter = "Comma Delimited Files|*.csv";
            this.csvFileDialog.InitialDirectory = "c:\\";
            // 
            // FrmFindPairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnLoadCSV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmFindPairs";
            this.Text = "Find Pairs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnLoadCSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog csvFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID01;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID02;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysWorked;
    }
}

