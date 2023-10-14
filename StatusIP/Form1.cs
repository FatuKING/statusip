using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;

namespace StatusIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("IP", "IP");
            dataGridView1.Columns.Add("Status", "Status");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ArchivoDatos = File.ReadAllLines("config.csv");
            ArchivoDatos = ArchivoDatos.Skip(1).ToArray();
            dataGridView1.Rows.Clear();

            Ping PingIP = new Ping();

            foreach (var line in ArchivoDatos)
            {
                var partes = line.Split(',');
                var fila = new Lineas(partes[0], partes[1]);

                PingReply PingStatus = PingIP.Send(fila.IP);
                bool status = PingStatus.Status == IPStatus.Success;

                dataGridView1.Rows.Add(fila.Nombre, fila.IP, status);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
    public record Lineas(
     string Nombre,
     string IP
     );
}
