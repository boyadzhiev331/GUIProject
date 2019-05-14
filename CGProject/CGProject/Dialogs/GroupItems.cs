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
    public partial class GroupItems : Form
    {
        public Form1 form;
        public GroupItems()
        {
            InitializeComponent();
        }

        private void GroupItems_Load(object sender, EventArgs e)
        {
            allItemsListBox.Items.Clear();
            groupItemsListBox.Items.Clear();

            foreach (IDrawable item in this.form.Items)
            {
                if (item.GetType().Name != "GroupOfItems")
                {
                    this.allItemsListBox.Items.Add(item.GetType().Name);
                }
            }
        }

        private void AddToGroupBtn_Click(object sender, EventArgs e)
        {
            if (allItemsListBox.Items.Count > 0 && allItemsListBox.SelectedIndex != -1)
            {
                if (this.form.groupOfItems == null)
                {
                    this.form.groupOfItems = new Shapes.GroupOfItems(200);
                    this.form.Items.Add(form.groupOfItems);
                }
                IDrawable item = this.form.Items[allItemsListBox.SelectedIndex];
                this.form.Items.Remove(item);
                allItemsListBox.Items.RemoveAt(allItemsListBox.SelectedIndex);
                groupItemsListBox.Items.Add(item.GetType().Name);
                this.form.groupOfItems.Items.Add(item);
                this.form.graphicsProcessor.SelectedItem = this.form.groupOfItems;
                this.form.CustomRefresh();
                allItemsListBox.SelectedIndex = allItemsListBox.Items.Count > 0 ? 0 : -1;
            }
        }

        private void AllItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allItemsListBox.Items.Count > 0 && allItemsListBox.SelectedIndex != -1)
            {
                form.SelectedItem = form.Items[allItemsListBox.SelectedIndex];
                form.ToggleSelection = 1;
                form.graphicsProcessor.SelectedItem = form.SelectedItem;
                form.CustomRefresh();
            }
        }

        private void RemoveFromGroupBtn_Click(object sender, EventArgs e)
        {
            if (groupItemsListBox.Items.Count > 0 && groupItemsListBox.SelectedIndex != -1)
            {
                IDrawable item = (IDrawable)this.form.groupOfItems.Items[groupItemsListBox.SelectedIndex];
                groupItemsListBox.Items.RemoveAt(groupItemsListBox.SelectedIndex);
                allItemsListBox.Items.Add(item.GetType().Name);
                this.form.groupOfItems.Items.Remove(item);
                this.form.Items.Add(item);
                this.form.CustomRefresh();
                groupItemsListBox.SelectedIndex = groupItemsListBox.Items.Count > 0 ? 0 : -1;
            }
        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {
            if (groupItemsListBox.Items.Count <= 1)
            {
                MessageBox.Show("Please, add more than 1 item to the group!");
            }
            else
            {
                this.form.SelectedItem = this.form.groupOfItems;
                this.form.graphicsProcessor.SelectedItem = this.form.groupOfItems;
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (this.form.groupOfItems != null)
            {
                foreach (IDrawable item in this.form.groupOfItems.Items)
                {
                    this.form.Items.Add(item);
                }
                this.form.groupOfItems = null;

            }
            this.Close();
        }
    }
}
