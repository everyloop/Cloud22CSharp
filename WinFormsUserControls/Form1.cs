namespace WinFormsUserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newPage = new("New page");
            tabControl1.TabPages.Add(newPage);
            UserControl1 myUserControl = new UserControl1();
            newPage.Controls.Add(myUserControl);
            myUserControl.Dock = DockStyle.Fill;
        }
    }
}