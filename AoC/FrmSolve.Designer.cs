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
            this.OfdInputFile = new System.Windows.Forms.OpenFileDialog();
            this.BtnInputFile = new System.Windows.Forms.Button();
            this.BtnSolvePart1 = new System.Windows.Forms.Button();
            this.TxtPart1 = new System.Windows.Forms.TextBox();
            this.TxtPart2 = new System.Windows.Forms.TextBox();
            this.LblPart1 = new System.Windows.Forms.Label();
            this.LblPart2 = new System.Windows.Forms.Label();
            this.BtnSolvePart2 = new System.Windows.Forms.Button();
            this.BtnWebpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboYear
            // 
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
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
            // OfdInputFile
            // 
            this.OfdInputFile.FileName = "OfdInputFile";
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
            // BtnSolvePart1
            // 
            this.BtnSolvePart1.Enabled = false;
            this.BtnSolvePart1.Location = new System.Drawing.Point(395, 287);
            this.BtnSolvePart1.Name = "BtnSolvePart1";
            this.BtnSolvePart1.Size = new System.Drawing.Size(166, 32);
            this.BtnSolvePart1.TabIndex = 3;
            this.BtnSolvePart1.Text = "Solve Part 1";
            this.BtnSolvePart1.UseVisualStyleBackColor = true;
            this.BtnSolvePart1.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // TxtPart1
            // 
            this.TxtPart1.Location = new System.Drawing.Point(190, 187);
            this.TxtPart1.Name = "TxtPart1";
            this.TxtPart1.ReadOnly = true;
            this.TxtPart1.Size = new System.Drawing.Size(100, 23);
            this.TxtPart1.TabIndex = 4;
            // 
            // TxtPart2
            // 
            this.TxtPart2.Location = new System.Drawing.Point(379, 187);
            this.TxtPart2.Name = "TxtPart2";
            this.TxtPart2.ReadOnly = true;
            this.TxtPart2.Size = new System.Drawing.Size(100, 23);
            this.TxtPart2.TabIndex = 5;
            // 
            // LblPart1
            // 
            this.LblPart1.AutoSize = true;
            this.LblPart1.Location = new System.Drawing.Point(190, 169);
            this.LblPart1.Name = "LblPart1";
            this.LblPart1.Size = new System.Drawing.Size(84, 15);
            this.LblPart1.TabIndex = 6;
            this.LblPart1.Text = "Part 1 Solution";
            // 
            // LblPart2
            // 
            this.LblPart2.AutoSize = true;
            this.LblPart2.Location = new System.Drawing.Point(379, 169);
            this.LblPart2.Name = "LblPart2";
            this.LblPart2.Size = new System.Drawing.Size(84, 15);
            this.LblPart2.TabIndex = 7;
            this.LblPart2.Text = "Part 2 Solution";
            // 
            // BtnSolvePart2
            // 
            this.BtnSolvePart2.Enabled = false;
            this.BtnSolvePart2.Location = new System.Drawing.Point(395, 338);
            this.BtnSolvePart2.Name = "BtnSolvePart2";
            this.BtnSolvePart2.Size = new System.Drawing.Size(166, 32);
            this.BtnSolvePart2.TabIndex = 8;
            this.BtnSolvePart2.Text = "Solve Part 2";
            this.BtnSolvePart2.UseVisualStyleBackColor = true;
            this.BtnSolvePart2.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnWebpage
            // 
            this.BtnWebpage.Location = new System.Drawing.Point(270, 42);
            this.BtnWebpage.Name = "BtnWebpage";
            this.BtnWebpage.Size = new System.Drawing.Size(193, 29);
            this.BtnWebpage.TabIndex = 9;
            this.BtnWebpage.Text = "Open the problem\'s webpage";
            this.BtnWebpage.UseVisualStyleBackColor = true;
            this.BtnWebpage.Click += new System.EventHandler(this.BtnWebpage_Click);
            // 
            // FrmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWebpage);
            this.Controls.Add(this.BtnSolvePart2);
            this.Controls.Add(this.LblPart2);
            this.Controls.Add(this.LblPart1);
            this.Controls.Add(this.TxtPart2);
            this.Controls.Add(this.TxtPart1);
            this.Controls.Add(this.BtnSolvePart1);
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
        private System.Windows.Forms.OpenFileDialog OfdInputFile;
        private System.Windows.Forms.Button BtnInputFile;
        private System.Windows.Forms.Button BtnSolvePart1;
        private System.Windows.Forms.TextBox TxtPart1;
        private System.Windows.Forms.TextBox TxtPart2;
        private System.Windows.Forms.Label LblPart1;
        private System.Windows.Forms.Label LblPart2;
        private System.Windows.Forms.Button BtnSolvePart2;
        private System.Windows.Forms.Button BtnWebpage;
    }
}
