using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace DecanatPRO
{
    public partial class FormAddStudent : Form
    {
        private readonly Logic _logic;

        public FormAddStudent(Logic logic)
        {
            _logic = logic;
            InitializeComponent();
        }

        private void ValidateInput()
        {
            if (textBoxName.Text == "" || textBoxGroup.Text == "" || textBoxSpec.Text == "")
            {
                buttonAdd.Enabled = false;
            }

            buttonAdd.Enabled = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void textBoxSpec_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void textBoxGroup_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _logic.AddStudent(
                textBoxName.Text,
                textBoxSpec.Text,
                textBoxGroup.Text
            );
            Close();
        }
    }
}