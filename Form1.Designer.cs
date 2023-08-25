namespace 이주현
{

    using static System.Net.Mime.MediaTypeNames;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Xml.Linq;
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
                this.comboBox1 = new System.Windows.Forms.ComboBox();
                this.button1 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.button3 = new System.Windows.Forms.Button();
                this.button4 = new System.Windows.Forms.Button();
                this.button5 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.SuspendLayout();
                // 
                // comboBox1
                // 
                this.comboBox1.FormattingEnabled = true;
                this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
                this.comboBox1.Location = new System.Drawing.Point(26, 30);
                this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.comboBox1.Name = "comboBox1";
                this.comboBox1.Size = new System.Drawing.Size(111, 23);
                this.comboBox1.TabIndex = 0;
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(167, 29);
                this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(104, 22);
                this.button1.TabIndex = 1;
                this.button1.Text = "연결";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(26, 76);
                this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(111, 60);
                this.button2.TabIndex = 2;
                this.button2.Text = "LED_01_ON";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // button3
                // 
                this.button3.Location = new System.Drawing.Point(167, 76);
                this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(111, 60);
                this.button3.TabIndex = 3;
                this.button3.Text = "LED_01_OFF";
                this.button3.UseVisualStyleBackColor = true;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // button4
                // 
                this.button4.Location = new System.Drawing.Point(26, 142);
                this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(111, 60);
                this.button4.TabIndex = 4;
                this.button4.Text = "LED_02_ON";
                this.button4.UseVisualStyleBackColor = true;
                this.button4.Click += new System.EventHandler(this.button4_Click);
                // 
                // button5
                // 
                this.button5.Location = new System.Drawing.Point(167, 142);
                this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(111, 60);
                this.button5.TabIndex = 5;
                this.button5.Text = "LED_02_OFF";
                this.button5.UseVisualStyleBackColor = true;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                // 
                // textBox1
                // 
                this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.textBox1.Location = new System.Drawing.Point(26, 238);
                this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(111, 18);
                this.textBox1.TabIndex = 6;
                this.textBox1.Text = "Message :";
                // 
                // textBox2
                // 
                this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
                this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
                this.textBox2.Location = new System.Drawing.Point(26, 274);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(195, 18);
                this.textBox2.TabIndex = 7;
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(338, 325);
                this.Controls.Add(this.textBox2);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.button5);
                this.Controls.Add(this.button4);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.comboBox1);
                this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.Name = "Form1";
                this.Text = "Form1";
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private ComboBox comboBox1;
            private Button button1;
            private Button button2;
            private Button button3;
            private Button button4;
            private Button button5;
            private TextBox textBox1;
            private TextBox textBox2;
        }
    }
