namespace calculator_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num1_txt = new System.Windows.Forms.TextBox();
            this.num2_txt = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.times_btn = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1_txt
            // 
            this.num1_txt.Location = new System.Drawing.Point(257, 92);
            this.num1_txt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.num1_txt.Name = "num1_txt";
            this.num1_txt.Size = new System.Drawing.Size(308, 23);
            this.num1_txt.TabIndex = 0;
            this.num1_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2_txt
            // 
            this.num2_txt.Location = new System.Drawing.Point(257, 206);
            this.num2_txt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.num2_txt.Name = "num2_txt";
            this.num2_txt.Size = new System.Drawing.Size(308, 23);
            this.num2_txt.TabIndex = 1;
            this.num2_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(257, 283);
            this.result.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(308, 23);
            this.result.TabIndex = 2;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add_btn.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Yellow;
            this.add_btn.Location = new System.Drawing.Point(355, 327);
            this.add_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(115, 53);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.minus_btn.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_btn.ForeColor = System.Drawing.Color.Yellow;
            this.minus_btn.Location = new System.Drawing.Point(355, 388);
            this.minus_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(115, 53);
            this.minus_btn.TabIndex = 4;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = false;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // times_btn
            // 
            this.times_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.times_btn.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times_btn.ForeColor = System.Drawing.Color.Yellow;
            this.times_btn.Location = new System.Drawing.Point(355, 449);
            this.times_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.times_btn.Name = "times_btn";
            this.times_btn.Size = new System.Drawing.Size(115, 53);
            this.times_btn.TabIndex = 5;
            this.times_btn.Text = "X";
            this.times_btn.UseVisualStyleBackColor = false;
            this.times_btn.Click += new System.EventHandler(this.times_btn_Click);
            // 
            // division_btn
            // 
            this.division_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.division_btn.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_btn.ForeColor = System.Drawing.Color.Yellow;
            this.division_btn.Location = new System.Drawing.Point(355, 520);
            this.division_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(115, 53);
            this.division_btn.TabIndex = 6;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = false;
            this.division_btn.Click += new System.EventHandler(this.division_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear_btn.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.Yellow;
            this.clear_btn.Location = new System.Drawing.Point(355, 571);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 53);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(830, 639);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.division_btn);
            this.Controls.Add(this.times_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2_txt);
            this.Controls.Add(this.num1_txt);
            this.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1_txt;
        private System.Windows.Forms.TextBox num2_txt;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button times_btn;
        private System.Windows.Forms.Button division_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

