
namespace ComplexNumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRe = new System.Windows.Forms.TextBox();
            this.textBoxIm = new System.Windows.Forms.TextBox();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "to str";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRe
            // 
            this.textBoxRe.Location = new System.Drawing.Point(78, 42);
            this.textBoxRe.Name = "textBoxRe";
            this.textBoxRe.Size = new System.Drawing.Size(125, 27);
            this.textBoxRe.TabIndex = 1;
            // 
            // textBoxIm
            // 
            this.textBoxIm.Location = new System.Drawing.Point(78, 87);
            this.textBoxIm.Name = "textBoxIm";
            this.textBoxIm.Size = new System.Drawing.Size(125, 27);
            this.textBoxIm.TabIndex = 2;
            // 
            // textBoxStr
            // 
            this.textBoxStr.Location = new System.Drawing.Point(78, 170);
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.Size = new System.Drawing.Size(125, 27);
            this.textBoxStr.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "re";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "im";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "str";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "abs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStr);
            this.Controls.Add(this.textBoxIm);
            this.Controls.Add(this.textBoxRe);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "add";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRe;
        private System.Windows.Forms.TextBox textBoxIm;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

