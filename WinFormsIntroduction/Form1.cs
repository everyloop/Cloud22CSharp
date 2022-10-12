namespace WinFormsIntroduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            buttonSend.Text = textBox1.Text;
            buttonExit.Enabled = !buttonExit.Enabled;
            MessageBox.Show(textBox1.Text);
        }
    }
}