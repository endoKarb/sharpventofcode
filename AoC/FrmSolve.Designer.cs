namespace AoC
{
    partial class FrmSolver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.CboDay = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnInputFile = new System.Windows.Forms.Button();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CboYear
            // 
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Items.AddRange(new object[] {
            "2015"});
            this.CboYear.Location = new System.Drawing.Point(132, 106);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(182, 23);
            this.CboYear.TabIndex = 0;
            // 
            // CboDay
            // 
            this.CboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDay.FormattingEnabled = true;
            this.CboDay.Items.AddRange(new object[] {
            "Day 1"});
            this.CboDay.Location = new System.Drawing.Point(379, 106);
            this.CboDay.Name = "CboDay";
            this.CboDay.Size = new System.Drawing.Size(182, 23);
            this.CboDay.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnInputFile
            // 
            this.BtnInputFile.Location = new System.Drawing.Point(113, 287);
            this.BtnInputFile.Name = "BtnInputFile";
            this.BtnInputFile.Size = new System.Drawing.Size(163, 32);
            this.BtnInputFile.TabIndex = 2;
            this.BtnInputFile.Text = "Load File...";
            this.BtnInputFile.UseVisualStyleBackColor = true;
            this.BtnInputFile.Click += new System.EventHandler(this.BtnInputFile_Click);
            // 
            // BtnSolve
            // 
            this.BtnSolve.Enabled = false;
            this.BtnSolve.Location = new System.Drawing.Point(395, 287);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(166, 32);
            this.BtnSolve.TabIndex = 3;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(308, 200);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(100, 23);
            this.TxtResult.TabIndex = 4;
            // 
            // FrmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnSolve);
            this.Controls.Add(this.BtnInputFile);
            this.Controls.Add(this.CboDay);
            this.Controls.Add(this.CboYear);
            this.Name = "FrmSolver";
            this.Text = "Advent of Code Solvers Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.ComboBox CboDay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnInputFile;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.TextBox TxtResult;
    }
}
