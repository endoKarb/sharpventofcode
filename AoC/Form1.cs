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
        public Dictionary<string, Type> solvers;
        public Form1()
        {
            InitializeComponent();
            CboYear.SelectedIndex = 0;
            CboDay.SelectedIndex = 0;
            solvers = InitSolvers();
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BtnSolve.Enabled = true;
            }
        }
        private Dictionary<string, Type> InitSolvers()
        {
            return new Dictionary<string, Type>
            {
                ["2015-Day 1"] = new _2015Day1Solver("path").GetType()
            };
        }
        Solver CreateSolver(string year, string day, string inputPath)
        {
            object? o = Activator.CreateInstance(solvers[$"{year}-{day}"], inputPath);
            object s = o ?? -1;
            Debug.WriteLine(s.GetType());
            return (Solver) s;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day = CboDay.GetItemText(CboDay.SelectedItem);
            string path = openFileDialog1.FileName;
            Debug.WriteLine(path);
            var slv = CreateSolver(year, day, path);
        }
    }
}
