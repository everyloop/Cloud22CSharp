namespace WinFormsLoadFile
{
    public partial class Form1 : Form
    {
        private string? currentFileName = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog.FileName;
                this.Text = currentFileName;

                using (StreamReader reader = new StreamReader(currentFileName))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(currentFileName ?? "New File");
            var result = MessageBox.Show($"Do you want to save unsaved changes to '{filename}'", "Save changes?", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                if (!SaveFile()) return;
            }
            
            textBox1.Text = String.Empty;
            currentFileName = null;
            this.Text = "New File";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private bool SaveFile()
        {
            if (currentFileName is null)
            {
                return ShowSaveFileDialog();
            }
            else
            {
                SaveFileAs(currentFileName);
                return true;
            }
        }

        private bool ShowSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.InitialDirectory = Path.GetDirectoryName(currentFileName ?? string.Empty);
            saveFileDialog.FileName = Path.GetFileName(currentFileName ?? string.Empty);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveFileDialog.FileName;
                SaveFileAs(currentFileName);
                return true;
            }

            return false;
        }

        private void SaveFileAs(string filename)
        {
            textBox1.Modified = false;
            this.Text = currentFileName;

            using (StreamWriter writer = new(filename))
            {
                writer.Write(textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = (currentFileName ?? "New File") + (textBox1.Modified ? "*" : "");
        }
    }
}