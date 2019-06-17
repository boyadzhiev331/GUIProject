using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGProject.Interfaces;

namespace CGProject.Dialogs
{
    public partial class FindItem : Form
    {
        public Form1 form;

        public FindItem()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (findItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please, select an item :)");
            }
            else
            {
                this.Close();
            }
        }

        private void FindItem_Load(object sender, EventArgs e)
        {
            findItemsListBox.Items.Clear();

            foreach (IDrawable item in this.form.Items)
            {
                this.findItemsListBox.Items.Add(item.Name);
            }
        }

        private void FindItemsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (findItemsListBox.SelectedIndex > -1)
            {
                form.SelectedItem = (IDrawable)form.Items[findItemsListBox.SelectedIndex];
                form.ToggleSelection = 1;
                form.graphicsProcessor.SelectedItem = (ITransformable)form.SelectedItem;
                form.CustomRefresh();
            }
        }
    }
}
