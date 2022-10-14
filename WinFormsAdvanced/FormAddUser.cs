using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdvanced
{
    public partial class FormAddUser : Form
    {
        public string FirstName
        {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }

        public bool UserActivated
        {
            get { return checkBoxActivated.Checked; }
            set { checkBoxActivated.Checked = value; }
        }

        private bool _editMode = false;

        public bool EditMode
        {
            get { return _editMode; }
            set 
            { 
                _editMode = value;
                buttonAdd.Text = _editMode ? "Save" : "Add";
                this.Text = _editMode ? "Edit user" : "Add user"; // Ternary operator (condition ? if_true : if_false)

            }
        }

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
