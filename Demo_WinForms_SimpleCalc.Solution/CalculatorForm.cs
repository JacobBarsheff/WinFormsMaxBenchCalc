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
    public partial class CalculatorForm : Form
    {
        const int MAX_WEIGHT_KG = 545;
        const int MAX_WEIGHT_LBS = 1200;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// set units labels on form based on radio buttons
        /// </summary>
        private void radBtn_English_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Lbs.Checked == true)
            {
                lbl_Weight.Text = "Weight (Lbs)";

            }
        }

        /// <summary>
        /// set units labels on form based on radio buttons
        /// </summary>
        private void radBtn_Metric_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Kg.Checked == true)
            {
                lbl_Weight.Text = "Weight (Kg)";

            }
        }

        /// <summary>
        /// validate user input in text boxes, return value or user feedback
        /// </summary>
        /// <param name="userInput">text box content</param>
        /// <param name="maxValue">maximum value</param>
        /// <param name="value">returned value</param>
        /// <param name="userFeedback">returned feedback</param>
        /// <returns>validated input status</returns>
        private bool ValidateUserInput(string userInput, double maxValue, out double value, out string userFeedback)
        {
            userFeedback = "";

            if (double.TryParse(userInput, out value))
            {
                if (value > 0 && value <= maxValue)
                {
                    return true;
                }
                else
                {
                    userFeedback = $" must be a number between 0 and {maxValue}.";
                    return false;
                }
            }
            else
            {
                userFeedback = $" must be a number.";
                return false;
            }
        }

        /// <summary>
        /// close form button event
        /// </summary>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// calculate the 1 rep max bench
        /// </summary>
        private void btn_CalculateMaxBench_Click(object sender, EventArgs e)
        {
            double weight = 0;
            double value;
            double maxWeight;
            int maxBench;
            int reps = 0;
            string validationFeedback;
            string userMessage = null;
            string unit = "lbs";

            //
            // assign max weight values based on selected button
            //
            if (radBtn_Lbs.Checked == true)
            {
                maxWeight = MAX_WEIGHT_LBS;
            }
            else
            {
                maxWeight = MAX_WEIGHT_KG;
                unit = "Kg";
            }

            //
            // validate user input weight and build out the feedback message
            //
            if (!ValidateUserInput(txtBox_weight.Text, maxWeight, out value, out validationFeedback))
            {
                userMessage += "The Weight" + validationFeedback + Environment.NewLine;
                txtBox_weight.Text = null;
            }
            else
            {
                weight = value;
                reps = (int)btn_numReps.Value;
            }
           

            if (userMessage != null)
            {
                //lbl_ErrorMessage.Text = userMessage;
                MessageBox.Show(userMessage);
            }
            //
            // open the SolutionForm
            //
            else
            {
                maxBench = MaxBench(weight, reps);

                Form solutionForm = new form_Solution(new SolutionFormInfo(maxBench, unit));
                solutionForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                solutionForm.MaximizeBox = false;
                solutionForm.MinimizeBox = false;
                solutionForm.ShowDialog();
                solutionForm.Dispose();
            }
        }

        /// <summary>
        /// calculate the number of people who fit
        /// </summary>
        /// <param name="weight">weight</param>
        /// <param name="reps">number of reps</param>
        /// <returns>max bench</returns>
        private int MaxBench(double weight, int reps)
        {

            double[] maxBenchArray = {1, .95, .93, .90, .87, .85,.83, .80, .77, .75, .73,.70};
            
            return (int)(weight / maxBenchArray[reps - 1]);
        }

        /// <summary>
        /// set up form on load event
        /// </summary>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// open help dialog box
        /// </summary>
        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            helpForm.MinimizeBox = false;
            helpForm.MaximizeBox = false;
            helpForm.ShowDialog();
            helpForm.Dispose();
        }


    }
}
