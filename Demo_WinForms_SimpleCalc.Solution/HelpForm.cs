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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            lbl_Directions.Text =
                "1) Choose either lbs or kilograms using the radio button." + Environment.NewLine +
                "2) Input a the current weight of the bench." + Environment.NewLine +
                "3) Input the number of reps, max being 12." + Environment.NewLine +
                "4) Click cacluate to get one rep max."
                ;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
