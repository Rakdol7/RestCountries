namespace Restcountries
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(53, 170);
            button1.Name = "button1";
            button1.Size = new Size(144, 101);
            button1.TabIndex = 0;
            button1.Tag = "RUS";
            button1.Text = "RUSSIA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 170);
            button2.Name = "button2";
            button2.Size = new Size(144, 101);
            button2.TabIndex = 1;
            button2.Tag = "DEU";
            button2.Text = "GERMANIA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(420, 170);
            button3.Name = "button3";
            button3.Size = new Size(144, 101);
            button3.TabIndex = 2;
            button3.Tag = "ESP";
            button3.Text = "SPAGNA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(605, 170);
            button4.Name = "button4";
            button4.Size = new Size(144, 101);
            button4.TabIndex = 3;
            button4.Tag = "NOR";
            button4.Text = "NORVEGIA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(53, 304);
            button5.Name = "button5";
            button5.Size = new Size(144, 101);
            button5.TabIndex = 4;
            button5.Tag = "AUT";
            button5.Text = "AUSTRIA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(240, 304);
            button6.Name = "button6";
            button6.Size = new Size(144, 101);
            button6.TabIndex = 5;
            button6.Tag = "BEL";
            button6.Text = "BELGIO";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(420, 304);
            button7.Name = "button7";
            button7.Size = new Size(144, 101);
            button7.TabIndex = 6;
            button7.Tag = "IDN";
            button7.Text = "INDONESIA";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(605, 304);
            button8.Name = "button8";
            button8.Size = new Size(144, 101);
            button8.TabIndex = 7;
            button8.Tag = "EGY";
            button8.Text = "EGITTO";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(494, 45);
            label1.TabIndex = 8;
            label1.Text = "QUALE STATO CONFINA CON L'";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(513, 42);
            label2.Name = "label2";
            label2.Size = new Size(119, 45);
            label2.TabIndex = 9;
            label2.Text = "ITALIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(619, 42);
            label3.Name = "label3";
            label3.Size = new Size(34, 45);
            label3.TabIndex = 10;
            label3.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
