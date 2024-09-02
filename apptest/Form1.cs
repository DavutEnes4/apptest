using System.Windows.Forms;

namespace apptest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(2000);
            Thread thread = new Thread(TcpServer.Listen);
            thread.Start();
            TcpServer.MessageReceived += TcpServer_MessageReceived;
        }
        private void TcpServer_MessageReceived(object sender, TcpServer.MessageReceivedEventArgs e)
        {
            // Güvenli bir þekilde UI güncellemesi yapmak için Invoke kullanýn
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateTextBox), e.Message);
            }
            else
            {
                UpdateTextBox(e.Message);
            }
        }
        private void UpdateTextBox(string message)
        {
            string tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            richTextBox1.AppendText(tarih + " > ");
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionColor = Color.Green;
            richTextBox1.AppendText(message + Environment.NewLine);
            richTextBox1.SelectionColor = richTextBox1.ForeColor;

            richTextBox1.ScrollToCaret();
        }
        internal void add(string text)
        {
            richTextBox1.Text += text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
