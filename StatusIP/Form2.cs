using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace StatusIP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ArchivoDatos = File.ReadAllLines("config.csv");
            ArchivoDatos = ArchivoDatos.Skip(1).ToArray();

            TextBox[] textBoxes = { textBox1, textBox2, textBox3 };
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
    }
}
