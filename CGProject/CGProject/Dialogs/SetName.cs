using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject.Dialogs
{
    public partial class SetName : Form
    {
        public Form1 form;
        public SetName()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                this.form.SelectedItem.Name = textBox1.Text;
                this.form.CustomRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please, enter a name.");
            }
        }
    }
}
