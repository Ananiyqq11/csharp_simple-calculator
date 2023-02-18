namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox_input_output = new System.Windows.Forms.TextBox();
            this.panel_btns = new System.Windows.Forms.Panel();
            this.button_c = new System.Windows.Forms.Button();
            this.button_divison = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_seven = new System.Windows.Forms.Button();
            this.button_eight = new System.Windows.Forms.Button();
            this.button_nine = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_four = new System.Windows.Forms.Button();
            this.button_five = new System.Windows.Forms.Button();
            this.button_six = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_one = new System.Windows.Forms.Button();
            this.button_two = new System.Windows.Forms.Button();
            this.button_three = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_zero = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.panel_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_input_output
            // 
            this.textBox_input_output.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input_output.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox_input_output.Location = new System.Drawing.Point(1, 0);
            this.textBox_input_output.Multiline = true;
            this.textBox_input_output.Name = "textBox_input_output";
            this.textBox_input_output.Size = new System.Drawing.Size(328, 55);
            this.textBox_input_output.TabIndex = 0;
            this.textBox_input_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_btns
            // 
            this.panel_btns.BackColor = System.Drawing.Color.LightGray;
            this.panel_btns.Controls.Add(this.button_equal);
            this.panel_btns.Controls.Add(this.button_point);
            this.panel_btns.Controls.Add(this.button_zero);
            this.panel_btns.Controls.Add(this.button_percent);
            this.panel_btns.Controls.Add(this.button_three);
            this.panel_btns.Controls.Add(this.button_two);
            this.panel_btns.Controls.Add(this.button_one);
            this.panel_btns.Controls.Add(this.button_plus);
            this.panel_btns.Controls.Add(this.button_six);
            this.panel_btns.Controls.Add(this.button_five);
            this.panel_btns.Controls.Add(this.button_four);
            this.panel_btns.Controls.Add(this.button_minus);
            this.panel_btns.Controls.Add(this.button_nine);
            this.panel_btns.Controls.Add(this.button_eight);
            this.panel_btns.Controls.Add(this.button_seven);
            this.panel_btns.Controls.Add(this.button_clear);
            this.panel_btns.Controls.Add(this.button_multiplication);
            this.panel_btns.Controls.Add(this.button_divison);
            this.panel_btns.Controls.Add(this.button_c);
            this.panel_btns.Location = new System.Drawing.Point(1, 55);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.Size = new System.Drawing.Size(328, 278);
            this.panel_btns.TabIndex = 1;
            // 
            // button_c
            // 
            this.button_c.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_c.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_c.Location = new System.Drawing.Point(4, 7);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(75, 46);
            this.button_c.TabIndex = 0;
            this.button_c.Text = "C";
            this.button_c.UseVisualStyleBackColor = false;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // button_divison
            // 
            this.button_divison.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_divison.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divison.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_divison.Location = new System.Drawing.Point(85, 7);
            this.button_divison.Name = "button_divison";
            this.button_divison.Size = new System.Drawing.Size(75, 46);
            this.button_divison.TabIndex = 1;
            this.button_divison.Text = "/";
            this.button_divison.UseVisualStyleBackColor = false;
            this.button_divison.Click += new System.EventHandler(this.button_divison_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_multiplication.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_multiplication.Location = new System.Drawing.Point(166, 7);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(75, 46);
            this.button_multiplication.TabIndex = 2;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = false;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_clear.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_clear.Location = new System.Drawing.Point(247, 7);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 46);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_seven
            // 
            this.button_seven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_seven.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_seven.Location = new System.Drawing.Point(4, 59);
            this.button_seven.Name = "button_seven";
            this.button_seven.Size = new System.Drawing.Size(75, 46);
            this.button_seven.TabIndex = 4;
            this.button_seven.Text = "7";
            this.button_seven.UseVisualStyleBackColor = false;
            this.button_seven.Click += new System.EventHandler(this.button_seven_Click);
            // 
            // button_eight
            // 
            this.button_eight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_eight.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_eight.Location = new System.Drawing.Point(85, 59);
            this.button_eight.Name = "button_eight";
            this.button_eight.Size = new System.Drawing.Size(75, 46);
            this.button_eight.TabIndex = 5;
            this.button_eight.Text = "8";
            this.button_eight.UseVisualStyleBackColor = false;
            this.button_eight.Click += new System.EventHandler(this.button_eight_Click);
            // 
            // button_nine
            // 
            this.button_nine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_nine.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_nine.Location = new System.Drawing.Point(166, 59);
            this.button_nine.Name = "button_nine";
            this.button_nine.Size = new System.Drawing.Size(75, 46);
            this.button_nine.TabIndex = 6;
            this.button_nine.Text = "9";
            this.button_nine.UseVisualStyleBackColor = false;
            this.button_nine.Click += new System.EventHandler(this.button_nine_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_minus.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_minus.Location = new System.Drawing.Point(247, 59);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 46);
            this.button_minus.TabIndex = 7;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_four
            // 
            this.button_four.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_four.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_four.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_four.Location = new System.Drawing.Point(4, 111);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(75, 46);
            this.button_four.TabIndex = 8;
            this.button_four.Text = "4";
            this.button_four.UseVisualStyleBackColor = false;
            this.button_four.Click += new System.EventHandler(this.button_four_Click);
            // 
            // button_five
            // 
            this.button_five.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_five.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_five.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_five.Location = new System.Drawing.Point(85, 111);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(75, 46);
            this.button_five.TabIndex = 9;
            this.button_five.Text = "5";
            this.button_five.UseVisualStyleBackColor = false;
            this.button_five.Click += new System.EventHandler(this.button_five_Click);
            // 
            // button_six
            // 
            this.button_six.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_six.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_six.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_six.Location = new System.Drawing.Point(166, 111);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(75, 46);
            this.button_six.TabIndex = 10;
            this.button_six.Text = "6";
            this.button_six.UseVisualStyleBackColor = false;
            this.button_six.Click += new System.EventHandler(this.button_six_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_plus.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_plus.Location = new System.Drawing.Point(247, 111);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 46);
            this.button_plus.TabIndex = 11;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_one
            // 
            this.button_one.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_one.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_one.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_one.Location = new System.Drawing.Point(4, 163);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(75, 46);
            this.button_one.TabIndex = 12;
            this.button_one.Text = "1";
            this.button_one.UseVisualStyleBackColor = false;
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button_two
            // 
            this.button_two.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_two.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_two.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_two.Location = new System.Drawing.Point(85, 163);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(75, 46);
            this.button_two.TabIndex = 13;
            this.button_two.Text = "2";
            this.button_two.UseVisualStyleBackColor = false;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_three
            // 
            this.button_three.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_three.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_three.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_three.Location = new System.Drawing.Point(166, 163);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(75, 46);
            this.button_three.TabIndex = 14;
            this.button_three.Text = "3";
            this.button_three.UseVisualStyleBackColor = false;
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_percent.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_percent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_percent.Location = new System.Drawing.Point(4, 215);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(75, 46);
            this.button_percent.TabIndex = 15;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = false;
            this.button_percent.Click += new System.EventHandler(this.button_percent_Click);
            // 
            // button_zero
            // 
            this.button_zero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_zero.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_zero.Location = new System.Drawing.Point(85, 215);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(75, 46);
            this.button_zero.TabIndex = 16;
            this.button_zero.Text = "0";
            this.button_zero.UseVisualStyleBackColor = false;
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_point
            // 
            this.button_point.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_point.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_point.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_point.Location = new System.Drawing.Point(166, 215);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(75, 46);
            this.button_point.TabIndex = 17;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = false;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_equal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_equal.Location = new System.Drawing.Point(247, 163);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(75, 98);
            this.button_equal.TabIndex = 18;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 324);
            this.Controls.Add(this.panel_btns);
            this.Controls.Add(this.textBox_input_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_btns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input_output;
        private System.Windows.Forms.Panel panel_btns;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_divison;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_zero;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_three;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_one;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_six;
        private System.Windows.Forms.Button button_five;
        private System.Windows.Forms.Button button_four;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_nine;
        private System.Windows.Forms.Button button_eight;
        private System.Windows.Forms.Button button_seven;
    }
}

