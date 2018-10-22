using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms_SimpleCalculator
{
    public partial class form_Solution : Form
    {
        SolutionFormInfo _solutionFormInfo; 

        public form_Solution(SolutionFormInfo solutionFormInfo)
        {
            _solutionFormInfo = solutionFormInfo;
            InitializeComponent();
        }

        private void form_Solution_Load(object sender, EventArgs e)
        {
            //
            // update controls based on the SolutionFormInfo struct passed
            //
            picBox_Body.Image = Image.FromFile(@"Media/bar.jpg");
            lbl_MaxBench.Text = _solutionFormInfo.MaxBench.ToString()+_solutionFormInfo.Unit;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
