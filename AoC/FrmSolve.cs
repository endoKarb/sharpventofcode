using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AoC
{
    public partial class FrmSolver : Form
    {
        public FrmSolver()
        {
            InitializeComponent();
            CboYear.SelectedIndex = 0;
            CboDay.SelectedIndex = 0;
        }
        static ISolver CreateSolver(string year, string day, string inputPath)
        {
            Type t = Type.GetType($"AoC.Year{year}{day}") ?? throw new Exception("Invalid Type");
            object o = Activator.CreateInstance(t, inputPath) ?? throw new Exception("");
            return (ISolver)o;
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            if (OfdInputFile.ShowDialog() == DialogResult.OK)
            {
                BtnSolve.Enabled = true;
                BtnSolvePart2.Enabled = true;
            }
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day = CboDay.GetItemText(CboDay.SelectedItem);
            day = string.Concat(day.Where(c => !char.IsWhiteSpace(c)));
            string path = OfdInputFile.FileName;
            var slv = CreateSolver(year, day, path);
            TxtPart1.Text = $"{slv.SolvePart1()}";
        }

        private void BtnSolvePart2_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day = CboDay.GetItemText(CboDay.SelectedItem);
            day = string.Concat(day.Where(c => !char.IsWhiteSpace(c)));
            string path = OfdInputFile.FileName;
            var slv = CreateSolver(year, day, path);
            TxtPart2.Text = $"{slv.SolvePart2()}";
        }
    }
}
