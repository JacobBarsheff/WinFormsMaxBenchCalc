namespace Demo_WinForms_SimpleCalculator
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.lvl_Directions = new System.Windows.Forms.Label();
            this.lbl_Directions = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl_Directions
            // 
            this.lvl_Directions.AutoSize = true;
            this.lvl_Directions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_Directions.Location = new System.Drawing.Point(16, 28);
            this.lvl_Directions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvl_Directions.Name = "lvl_Directions";
            this.lvl_Directions.Size = new System.Drawing.Size(109, 26);
            this.lvl_Directions.TabIndex = 0;
            this.lvl_Directions.Text = "Directions";
            // 
            // lbl_Directions
            // 
            this.lbl_Directions.AutoSize = true;
            this.lbl_Directions.Location = new System.Drawing.Point(18, 54);
            this.lbl_Directions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Directions.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbl_Directions.Name = "lbl_Directions";
            this.lbl_Directions.Size = new System.Drawing.Size(0, 13);
            this.lbl_Directions.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(14, 149);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 27);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 185);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Directions);
            this.Controls.Add(this.lvl_Directions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl_Directions;
        private System.Windows.Forms.Label lbl_Directions;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}