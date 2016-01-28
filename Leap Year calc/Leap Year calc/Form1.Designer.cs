namespace Leap_Year_calc
{
    partial class Frm_leapCalc
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
            this.btn_Calc = new System.Windows.Forms.Button();
            this.Txt_startYr = new System.Windows.Forms.TextBox();
            this.Pic_Frog = new System.Windows.Forms.PictureBox();
            this.Txt_Endyr = new System.Windows.Forms.TextBox();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Frog)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(352, 197);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(205, 51);
            this.btn_Calc.TabIndex = 3;
            this.btn_Calc.Text = "Calculate Leap Years";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // Txt_startYr
            // 
            this.Txt_startYr.AcceptsTab = true;
            this.Txt_startYr.Location = new System.Drawing.Point(457, 12);
            this.Txt_startYr.MaxLength = 4;
            this.Txt_startYr.Name = "Txt_startYr";
            this.Txt_startYr.Size = new System.Drawing.Size(100, 20);
            this.Txt_startYr.TabIndex = 1;
            // 
            // Pic_Frog
            // 
            this.Pic_Frog.Image = global::Leap_Year_calc.Properties.Resources.frog_1;
            this.Pic_Frog.Location = new System.Drawing.Point(0, 0);
            this.Pic_Frog.Name = "Pic_Frog";
            this.Pic_Frog.Size = new System.Drawing.Size(342, 260);
            this.Pic_Frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Frog.TabIndex = 2;
            this.Pic_Frog.TabStop = false;
            // 
            // Txt_Endyr
            // 
            this.Txt_Endyr.AcceptsTab = true;
            this.Txt_Endyr.Location = new System.Drawing.Point(457, 38);
            this.Txt_Endyr.MaxLength = 4;
            this.Txt_Endyr.Name = "Txt_Endyr";
            this.Txt_Endyr.Size = new System.Drawing.Size(100, 20);
            this.Txt_Endyr.TabIndex = 3;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.Location = new System.Drawing.Point(348, 12);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(103, 20);
            this.lbl_start.TabIndex = 4;
            this.lbl_start.Text = "Starting Year";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.Location = new System.Drawing.Point(354, 38);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(97, 20);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "Ending Year";
            // 
            // Frm_leapCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 260);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.Txt_Endyr);
            this.Controls.Add(this.Pic_Frog);
            this.Controls.Add(this.Txt_startYr);
            this.Controls.Add(this.btn_Calc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_leapCalc";
            this.Text = "Leap Year Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Frog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.TextBox Txt_startYr;
        private System.Windows.Forms.PictureBox Pic_Frog;
        private System.Windows.Forms.TextBox Txt_Endyr;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
    }
}

