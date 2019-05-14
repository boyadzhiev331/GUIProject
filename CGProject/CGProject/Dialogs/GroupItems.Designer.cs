namespace CGProject.Dialogs
{
    partial class GroupItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.allItemsListBox = new System.Windows.Forms.ListBox();
            this.groupBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupItemsListBox = new System.Windows.Forms.ListBox();
            this.addToGroupBtn = new System.Windows.Forms.Button();
            this.removeFromGroupBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // allItemsListBox
            // 
            this.allItemsListBox.FormattingEnabled = true;
            this.allItemsListBox.ItemHeight = 16;
            this.allItemsListBox.Location = new System.Drawing.Point(24, 96);
            this.allItemsListBox.Name = "allItemsListBox";
            this.allItemsListBox.Size = new System.Drawing.Size(120, 132);
            this.allItemsListBox.TabIndex = 4;
            this.allItemsListBox.SelectedIndexChanged += new System.EventHandler(this.AllItemsListBox_SelectedIndexChanged);
            // 
            // groupBtn
            // 
            this.groupBtn.Location = new System.Drawing.Point(38, 250);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(93, 31);
            this.groupBtn.TabIndex = 5;
            this.groupBtn.Text = "Group";
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.GroupBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(297, 250);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 33);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupItemsListBox
            // 
            this.groupItemsListBox.FormattingEnabled = true;
            this.groupItemsListBox.ItemHeight = 16;
            this.groupItemsListBox.Location = new System.Drawing.Point(282, 96);
            this.groupItemsListBox.Name = "groupItemsListBox";
            this.groupItemsListBox.Size = new System.Drawing.Size(120, 132);
            this.groupItemsListBox.TabIndex = 7;
            // 
            // addToGroupBtn
            // 
            this.addToGroupBtn.Location = new System.Drawing.Point(170, 96);
            this.addToGroupBtn.Name = "addToGroupBtn";
            this.addToGroupBtn.Size = new System.Drawing.Size(93, 33);
            this.addToGroupBtn.TabIndex = 8;
            this.addToGroupBtn.Text = "Add";
            this.addToGroupBtn.UseVisualStyleBackColor = true;
            this.addToGroupBtn.Click += new System.EventHandler(this.AddToGroupBtn_Click);
            // 
            // removeFromGroupBtn
            // 
            this.removeFromGroupBtn.Location = new System.Drawing.Point(170, 147);
            this.removeFromGroupBtn.Name = "removeFromGroupBtn";
            this.removeFromGroupBtn.Size = new System.Drawing.Size(93, 33);
            this.removeFromGroupBtn.TabIndex = 9;
            this.removeFromGroupBtn.Text = "Remove";
            this.removeFromGroupBtn.UseVisualStyleBackColor = true;
            this.removeFromGroupBtn.Click += new System.EventHandler(this.RemoveFromGroupBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(291, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Group";
            // 
            // GroupItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeFromGroupBtn);
            this.Controls.Add(this.addToGroupBtn);
            this.Controls.Add(this.groupItemsListBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBtn);
            this.Controls.Add(this.allItemsListBox);
            this.Controls.Add(this.label1);
            this.Name = "GroupItems";
            this.Text = "GroupItems";
            this.Load += new System.EventHandler(this.GroupItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox allItemsListBox;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox groupItemsListBox;
        private System.Windows.Forms.Button addToGroupBtn;
        private System.Windows.Forms.Button removeFromGroupBtn;
        private System.Windows.Forms.Label label2;
    }
}