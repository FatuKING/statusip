﻿namespace StatusIP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 20);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "IP";
            // 
            // button1
            // 
            button1.Location = new Point(237, 192);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 2;
            button1.Text = "guardar y salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 3;
            label3.Text = "Impresora Fiscal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 4;
            label4.Text = "Comandera Barra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 103);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 5;
            label5.Text = "Comandera Cocina";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 130);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 6;
            label6.Text = "PC Caja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 156);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 7;
            label7.Text = "PC Mozos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(180, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 23);
            textBox5.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 234);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Cafe Martinez";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}