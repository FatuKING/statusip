﻿namespace StatusIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            IP = new DataGridViewTextBoxColumn();
            Conectividad = new DataGridViewTextBoxColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 170);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 0;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, IP, Conectividad });
            dataGridView1.Location = new Point(10, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(305, 151);
            dataGridView1.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 70;
            // 
            // IP
            // 
            IP.HeaderText = "Dirección IP";
            IP.Name = "IP";
            IP.ReadOnly = true;
            // 
            // Conectividad
            // 
            Conectividad.HeaderText = "Conectividad";
            Conectividad.Name = "Conectividad";
            Conectividad.ReadOnly = true;
            Conectividad.Width = 90;
            // 
            // button2
            // 
            button2.Location = new Point(10, 169);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 2;
            button2.Text = "Configurar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 213);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cafe Martinez";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn Conectividad;
    }
}