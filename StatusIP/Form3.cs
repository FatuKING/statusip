using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusIP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            if (VerifyPassword(password))
            {
                this.Close();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            } else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }

        private bool VerifyPassword(string password)
        {
            return password == "hoguera";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
