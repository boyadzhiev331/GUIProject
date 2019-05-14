namespace CGProject.Dialogs
{
    partial class FindItem
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
            this.findBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.findItemsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(193, 57);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(93, 31);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(193, 109);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 33);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // findItemsListBox
            // 
            this.findItemsListBox.FormattingEnabled = true;
            this.findItemsListBox.ItemHeight = 16;
            this.findItemsListBox.Location = new System.Drawing.Point(31, 57);
            this.findItemsListBox.Name = "findItemsListBox";
            this.findItemsListBox.Size = new System.Drawing.Size(120, 132);
            this.findItemsListBox.TabIndex = 3;
            this.findItemsListBox.SelectedIndexChanged += new System.EventHandler(this.FindItemsListBox_SelectedIndexChanged_1);
            // 
            // FindItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 214);
            this.Controls.Add(this.findItemsListBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.label1);
            this.Name = "FindItem";
            this.Text = "FindItem";
            this.Load += new System.EventHandler(this.FindItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox findItemsListBox;
    }
}