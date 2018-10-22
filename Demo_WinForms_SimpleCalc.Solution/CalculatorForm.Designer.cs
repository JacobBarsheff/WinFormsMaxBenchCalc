namespace Demo_WinForms_SimpleCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.picBox_Bench = new System.Windows.Forms.PictureBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.txtBox_weight = new System.Windows.Forms.TextBox();
            this.lbl_NumReps = new System.Windows.Forms.Label();
            this.grpBox_Units = new System.Windows.Forms.GroupBox();
            this.radBtn_Kg = new System.Windows.Forms.RadioButton();
            this.radBtn_Lbs = new System.Windows.Forms.RadioButton();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.btn_CalculateMaxBench = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_numReps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Bench)).BeginInit();
            this.grpBox_Units.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_numReps)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.Location = new System.Drawing.Point(64, 21);
            this.lbl_FormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(289, 26);
            this.lbl_FormTitle.TabIndex = 0;
            this.lbl_FormTitle.Text = "1 Rep Max Bench Calculator";
            // 
            // picBox_Bench
            // 
            this.picBox_Bench.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Bench.Image")));
            this.picBox_Bench.Location = new System.Drawing.Point(26, 49);
            this.picBox_Bench.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_Bench.Name = "picBox_Bench";
            this.picBox_Bench.Size = new System.Drawing.Size(172, 228);
            this.picBox_Bench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Bench.TabIndex = 1;
            this.picBox_Bench.TabStop = false;
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Location = new System.Drawing.Point(222, 117);
            this.lbl_Weight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(67, 13);
            this.lbl_Weight.TabIndex = 2;
            this.lbl_Weight.Text = "Weight (Lbs)";
            // 
            // txtBox_weight
            // 
            this.txtBox_weight.Location = new System.Drawing.Point(318, 114);
            this.txtBox_weight.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_weight.Name = "txtBox_weight";
            this.txtBox_weight.Size = new System.Drawing.Size(76, 20);
            this.txtBox_weight.TabIndex = 1;
            // 
            // lbl_NumReps
            // 
            this.lbl_NumReps.AutoSize = true;
            this.lbl_NumReps.Location = new System.Drawing.Point(222, 149);
            this.lbl_NumReps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NumReps.Name = "lbl_NumReps";
            this.lbl_NumReps.Size = new System.Drawing.Size(84, 13);
            this.lbl_NumReps.TabIndex = 4;
            this.lbl_NumReps.Text = "Number of Reps";
            // 
            // grpBox_Units
            // 
            this.grpBox_Units.Controls.Add(this.radBtn_Kg);
            this.grpBox_Units.Controls.Add(this.radBtn_Lbs);
            this.grpBox_Units.Location = new System.Drawing.Point(209, 50);
            this.grpBox_Units.Margin = new System.Windows.Forms.Padding(2);
            this.grpBox_Units.Name = "grpBox_Units";
            this.grpBox_Units.Padding = new System.Windows.Forms.Padding(2);
            this.grpBox_Units.Size = new System.Drawing.Size(194, 30);
            this.grpBox_Units.TabIndex = 8;
            this.grpBox_Units.TabStop = false;
            this.grpBox_Units.Text = "Units";
            // 
            // radBtn_Kg
            // 
            this.radBtn_Kg.AutoSize = true;
            this.radBtn_Kg.Location = new System.Drawing.Point(126, 8);
            this.radBtn_Kg.Margin = new System.Windows.Forms.Padding(2);
            this.radBtn_Kg.Name = "radBtn_Kg";
            this.radBtn_Kg.Size = new System.Drawing.Size(38, 17);
            this.radBtn_Kg.TabIndex = 1;
            this.radBtn_Kg.Text = "Kg";
            this.radBtn_Kg.UseVisualStyleBackColor = true;
            this.radBtn_Kg.CheckedChanged += new System.EventHandler(this.radBtn_Metric_CheckedChanged);
            // 
            // radBtn_Lbs
            // 
            this.radBtn_Lbs.AutoSize = true;
            this.radBtn_Lbs.Checked = true;
            this.radBtn_Lbs.Location = new System.Drawing.Point(58, 8);
            this.radBtn_Lbs.Margin = new System.Windows.Forms.Padding(2);
            this.radBtn_Lbs.Name = "radBtn_Lbs";
            this.radBtn_Lbs.Size = new System.Drawing.Size(42, 17);
            this.radBtn_Lbs.TabIndex = 0;
            this.radBtn_Lbs.TabStop = true;
            this.radBtn_Lbs.Text = "Lbs";
            this.radBtn_Lbs.UseVisualStyleBackColor = true;
            this.radBtn_Lbs.CheckedChanged += new System.EventHandler(this.radBtn_English_CheckedChanged);
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(382, 82);
            this.lbl_ErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ErrorMessage.MaximumSize = new System.Drawing.Size(225, 0);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_ErrorMessage.TabIndex = 10;
            // 
            // btn_CalculateMaxBench
            // 
            this.btn_CalculateMaxBench.Location = new System.Drawing.Point(209, 196);
            this.btn_CalculateMaxBench.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CalculateMaxBench.Name = "btn_CalculateMaxBench";
            this.btn_CalculateMaxBench.Size = new System.Drawing.Size(194, 27);
            this.btn_CalculateMaxBench.TabIndex = 11;
            this.btn_CalculateMaxBench.Text = "Calculate Max Bench!";
            this.btn_CalculateMaxBench.UseVisualStyleBackColor = true;
            this.btn_CalculateMaxBench.Click += new System.EventHandler(this.btn_CalculateMaxBench_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(209, 237);
            this.btn_Help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(56, 27);
            this.btn_Help.TabIndex = 12;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(347, 237);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 27);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_numReps
            // 
            this.btn_numReps.Location = new System.Drawing.Point(318, 147);
            this.btn_numReps.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.btn_numReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.btn_numReps.Name = "btn_numReps";
            this.btn_numReps.Size = new System.Drawing.Size(76, 20);
            this.btn_numReps.TabIndex = 10;
            this.btn_numReps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 307);
            this.Controls.Add(this.btn_numReps);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_CalculateMaxBench);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.grpBox_Units);
            this.Controls.Add(this.txtBox_weight);
            this.Controls.Add(this.lbl_NumReps);
            this.Controls.Add(this.lbl_Weight);
            this.Controls.Add(this.picBox_Bench);
            this.Controls.Add(this.lbl_FormTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Bench)).EndInit();
            this.grpBox_Units.ResumeLayout(false);
            this.grpBox_Units.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_numReps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.PictureBox picBox_Bench;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.TextBox txtBox_weight;
        private System.Windows.Forms.Label lbl_NumReps;
        private System.Windows.Forms.GroupBox grpBox_Units;
        private System.Windows.Forms.RadioButton radBtn_Kg;
        private System.Windows.Forms.RadioButton radBtn_Lbs;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Button btn_CalculateMaxBench;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.NumericUpDown btn_numReps;
    }
}

