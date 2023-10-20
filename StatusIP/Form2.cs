using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StatusIP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string[] ArchivoDatos = File.ReadAllLines("config.csv");
            ArchivoDatos = ArchivoDatos.Skip(1).ToArray();

            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            int textBoxIndex = 0;

            foreach (var line in ArchivoDatos)
            {
                var partes = line.Split(',');
                var fila = new Lineas(partes[0], partes[1]);

                if (textBoxIndex < textBoxes.Length)
                {
                    textBoxes[textBoxIndex].Text = fila.IP;
                    textBoxIndex++;
                }
            }

        }
        public record Lineas(
        string Nombre,
        string IP
        );

        private void button1_Click(object sender, EventArgs e)
        {
            string[] newValue = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };

            string[] lineas = File.ReadAllLines("config.csv");

            for (int i = 1; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(',');
                if (i - 1 < newValue.Length)
                {
                    partes[1] = newValue[i - 1];
                    lineas[i] = string.Join(",", partes);
                }
            }

            File.WriteAllLines("config.csv", lineas);

            this.Close();
        }
    }
}
