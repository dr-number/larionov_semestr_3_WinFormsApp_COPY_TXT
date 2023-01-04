namespace larionov_WinFormsApp_COPY_TXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendText_Click(object sender, EventArgs e)
        {
            textBox_output.Text += textBox1.Text + "\n";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}