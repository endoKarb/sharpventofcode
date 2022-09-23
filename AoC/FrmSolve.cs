using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
                BtnSolvePart1.Enabled = true;
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
            Debug.WriteLine(((Button)sender).Name);
            switch (((Button)sender).Name)
            {
                case "BtnSolvePart1":
                    TxtPart1.Text = $"{slv.SolvePart1()}";
                    break;
                case "BtnSolvePart2":
                    TxtPart2.Text = $"{slv.SolvePart2()}";
                    break;
                default:
                    break;
            }
        }

        private void BtnWebpage_Click(object sender, EventArgs e)
        {
            string year = CboYear.GetItemText(CboYear.SelectedItem);
            string day= CboYear.GetItemText(CboDay.SelectedItem);
            Debug.WriteLine(day);
            day = day.Split(' ')[1];
            string target = $"https://adventofcode.com/{year}/day/{day}";
            try
            {
                Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
