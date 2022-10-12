namespace WinFormsMultiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Do you want open a new form?", "Question:", MessageBoxButtons.YesNo);

            FormEnterName form = new();
            //form.Name = "Fredrik";
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                label1.Text = $"Your name is {form.UserName}";
            }
            else
            {
                label1.Text = $"Please tell me your name!";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button myButton = new Button();
            myButton.Text = "My Button";
            myButton.Size = new Size(50, 20);
            myButton.Location = new Point(10, 10);
            this.Controls.Add(myButton);
        }
    }
}