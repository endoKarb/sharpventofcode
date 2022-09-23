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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CboYear.SelectedIndex = 0;
            CboDay.SelectedIndex = 0;
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BtnSolve.Enabled = true;
            }
        }
        Solver CreateSolver(string year, string day, string inputPath)
        {
            Type t = Type.GetType($"AoC.Year{year}{day}");
            object? o = Activator.CreateInstance(t, inputPath);
            object s = o ?? -1;
            Debug.WriteLine(s.GetType());
            return (Solver) s;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day = CboDay.GetItemText(CboDay.SelectedItem);
            day = string.Concat(day.Where(c => !char.IsWhiteSpace(c)));
            string path = openFileDialog1.FileName;
            //Debug.WriteLine(path);
            var slv = CreateSolver(year, day, path);
        }
    }
}
