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
        string? filepath;
        public Dictionary<string, Type> solvers;
        public Form1()
        {
            InitializeComponent();
            CboYear.SelectedIndex = 0;
            CboDay.SelectedIndex = 0;
            InitSolver();
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
            } else
            {
                filepath = null;
            }
        }
        private void InitSolver()
        {
            solvers = new Dictionary<string, Type>
            {
                ["2015-Day 1"] = new _2015Day1Solver("path").GetType()
            };
        }
        void s(string year, string day)
        {
            Object o = Activator.CreateInstance(solvers[$"{year}-{day}"], "filepath");
            Debug.WriteLine(o.GetType());
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day = CboDay.GetItemText(CboDay.SelectedItem);
            s(year, day);
        }
    }
}
