namespace DynamicProgramming
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxB4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxC2);
            this.panel1.Controls.Add(this.textBoxC1);
            this.panel1.Controls.Add(this.textBoxB4);
            this.panel1.Controls.Add(this.textBoxB3);
            this.panel1.Controls.Add(this.textBoxB2);
            this.panel1.Controls.Add(this.textBoxB1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 34);
            this.panel1.TabIndex = 0;
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(38, 5);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(60, 20);
            this.textBoxB1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "b1";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(137, 5);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(60, 20);
            this.textBoxB2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b2";
            // 
            // textBoxB3
            // 
            this.textBoxB3.Location = new System.Drawing.Point(237, 5);
            this.textBoxB3.Name = "textBoxB3";
            this.textBoxB3.Size = new System.Drawing.Size(60, 20);
            this.textBoxB3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "b3";
            // 
            // textBoxB4
            // 
            this.textBoxB4.Location = new System.Drawing.Point(340, 5);
            this.textBoxB4.Name = "textBoxB4";
            this.textBoxB4.Size = new System.Drawing.Size(60, 20);
            this.textBoxB4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "b4";
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(507, 5);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(60, 20);
            this.textBoxC1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "C1";
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(605, 5);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(60, 20);
            this.textBoxC2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "C2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 505);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dynamic progrmming";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxB4;
        private System.Windows.Forms.TextBox textBoxB3;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.TextBox textBoxB1;
    }
}

