namespace Demo_WinForms_SimpleCalculator
{
    partial class form_Solution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Solution));
            this.picBox_Body = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.lbl_MaxBench = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Body
            // 
            this.picBox_Body.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Body.Image")));
            this.picBox_Body.Location = new System.Drawing.Point(0, -21);
            this.picBox_Body.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_Body.Name = "picBox_Body";
            this.picBox_Body.Size = new System.Drawing.Size(325, 238);
            this.picBox_Body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Body.TabIndex = 0;
            this.picBox_Body.TabStop = false;
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.Location = new System.Drawing.Point(11, 18);
            this.lbl_FormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(299, 26);
            this.lbl_FormTitle.TabIndex = 1;
            this.lbl_FormTitle.Text = "Your estimated 1 Rep Max is:";
            // 
            // lbl_MaxBench
            // 
            this.lbl_MaxBench.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaxBench.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaxBench.Location = new System.Drawing.Point(87, 118);
            this.lbl_MaxBench.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaxBench.Name = "lbl_MaxBench";
            this.lbl_MaxBench.Size = new System.Drawing.Size(155, 64);
            this.lbl_MaxBench.TabIndex = 2;
            this.lbl_MaxBench.Text = "NOP";
            this.lbl_MaxBench.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(258, 154);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 28);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // form_Solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 192);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_MaxBench);
            this.Controls.Add(this.lbl_FormTitle);
            this.Controls.Add(this.picBox_Body);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "form_Solution";
            this.Load += new System.EventHandler(this.form_Solution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Body)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Body;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.Label lbl_MaxBench;
        private System.Windows.Forms.Button btn_Close;
    }
}