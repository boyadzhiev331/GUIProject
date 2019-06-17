using System;

namespace CGProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.OpacityChangeBtn = new System.Windows.Forms.NumericUpDown();
            this.OpacityBtnLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antonioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.danielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.findItemBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.breakBtn = new System.Windows.Forms.Button();
            this.groupBtn = new System.Windows.Forms.Button();
            this.DrawCurveBtn = new System.Windows.Forms.Button();
            this.DrawPolygonBtn = new System.Windows.Forms.Button();
            this.DrawLineBtn = new System.Windows.Forms.Button();
            this.ChangeClrBtn = new System.Windows.Forms.Button();
            this.DrawEllipseBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.DrawRectBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.renameItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityChangeBtn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "nothing is selected";
            // 
            // OpacityChangeBtn
            // 
            this.OpacityChangeBtn.Enabled = false;
            this.OpacityChangeBtn.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.OpacityChangeBtn.Location = new System.Drawing.Point(616, 69);
            this.OpacityChangeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpacityChangeBtn.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OpacityChangeBtn.Name = "OpacityChangeBtn";
            this.OpacityChangeBtn.ReadOnly = true;
            this.OpacityChangeBtn.Size = new System.Drawing.Size(55, 22);
            this.OpacityChangeBtn.TabIndex = 9;
            this.OpacityChangeBtn.ValueChanged += new System.EventHandler(this.OpacityChangeBtn_ValueChanged);
            // 
            // OpacityBtnLabel
            // 
            this.OpacityBtnLabel.AutoSize = true;
            this.OpacityBtnLabel.Location = new System.Drawing.Point(613, 43);
            this.OpacityBtnLabel.Name = "OpacityBtnLabel";
            this.OpacityBtnLabel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpacityBtnLabel.Size = new System.Drawing.Size(74, 21);
            this.OpacityBtnLabel.TabIndex = 10;
            this.OpacityBtnLabel.Text = "Opacity   ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "drawer files (*.drwr)|*.drwr";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator5,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.openToolStripMenuItem.Text = "Open..";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(136, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.groupToolStripMenuItem,
            this.breakToolStripMenuItem,
            this.toolStripSeparator2,
            this.findItemToolStripMenuItem,
            this.renameItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.GroupToolStripMenuItem_Click);
            // 
            // breakToolStripMenuItem
            // 
            this.breakToolStripMenuItem.Name = "breakToolStripMenuItem";
            this.breakToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.breakToolStripMenuItem.Text = "Break";
            this.breakToolStripMenuItem.Click += new System.EventHandler(this.BreakToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // findItemToolStripMenuItem
            // 
            this.findItemToolStripMenuItem.Name = "findItemToolStripMenuItem";
            this.findItemToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.findItemToolStripMenuItem.Text = "Find item";
            this.findItemToolStripMenuItem.Click += new System.EventHandler(this.FindItemToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antonioToolStripMenuItem,
            this.toolStripSeparator4,
            this.danielToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // antonioToolStripMenuItem
            // 
            this.antonioToolStripMenuItem.Name = "antonioToolStripMenuItem";
            this.antonioToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.antonioToolStripMenuItem.Text = "A. Boyadzhiev";
            this.antonioToolStripMenuItem.Click += new System.EventHandler(this.AntonioToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(174, 6);
            // 
            // danielToolStripMenuItem
            // 
            this.danielToolStripMenuItem.Name = "danielToolStripMenuItem";
            this.danielToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.danielToolStripMenuItem.Text = "D. Ivanov";
            this.danielToolStripMenuItem.Click += new System.EventHandler(this.DanielToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 93);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Group ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 93);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Break";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 93);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Copy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 93);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Paste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 93);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 93);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Find item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 93);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 93);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label9.Size = new System.Drawing.Size(98, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Change color";
            // 
            // findItemBtn
            // 
            this.findItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("findItemBtn.Image")));
            this.findItemBtn.Location = new System.Drawing.Point(539, 43);
            this.findItemBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findItemBtn.Name = "findItemBtn";
            this.findItemBtn.Size = new System.Drawing.Size(56, 48);
            this.findItemBtn.TabIndex = 18;
            this.findItemBtn.UseVisualStyleBackColor = true;
            this.findItemBtn.Click += new System.EventHandler(this.FindItemBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(461, 43);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(56, 48);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("pasteBtn.Image")));
            this.pasteBtn.Location = new System.Drawing.Point(384, 43);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(56, 48);
            this.pasteBtn.TabIndex = 16;
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Image = ((System.Drawing.Image)(resources.GetObject("copyBtn.Image")));
            this.copyBtn.Location = new System.Drawing.Point(309, 43);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(56, 48);
            this.copyBtn.TabIndex = 15;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // breakBtn
            // 
            this.breakBtn.Image = ((System.Drawing.Image)(resources.GetObject("breakBtn.Image")));
            this.breakBtn.Location = new System.Drawing.Point(233, 43);
            this.breakBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.breakBtn.Name = "breakBtn";
            this.breakBtn.Size = new System.Drawing.Size(56, 48);
            this.breakBtn.TabIndex = 14;
            this.breakBtn.UseVisualStyleBackColor = true;
            this.breakBtn.Click += new System.EventHandler(this.BreakBtn_Click);
            // 
            // groupBtn
            // 
            this.groupBtn.Image = ((System.Drawing.Image)(resources.GetObject("groupBtn.Image")));
            this.groupBtn.Location = new System.Drawing.Point(159, 43);
            this.groupBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(56, 48);
            this.groupBtn.TabIndex = 13;
            this.groupBtn.UseVisualStyleBackColor = true;
            this.groupBtn.Click += new System.EventHandler(this.GroupBtn_Click);
            // 
            // DrawCurveBtn
            // 
            this.DrawCurveBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawCurveBtn.Image")));
            this.DrawCurveBtn.Location = new System.Drawing.Point(12, 351);
            this.DrawCurveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawCurveBtn.Name = "DrawCurveBtn";
            this.DrawCurveBtn.Size = new System.Drawing.Size(56, 46);
            this.DrawCurveBtn.TabIndex = 8;
            this.DrawCurveBtn.UseVisualStyleBackColor = true;
            this.DrawCurveBtn.Click += new System.EventHandler(this.DrawCurveBtn_Click);
            // 
            // DrawPolygonBtn
            // 
            this.DrawPolygonBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawPolygonBtn.Image")));
            this.DrawPolygonBtn.Location = new System.Drawing.Point(12, 300);
            this.DrawPolygonBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawPolygonBtn.Name = "DrawPolygonBtn";
            this.DrawPolygonBtn.Size = new System.Drawing.Size(56, 46);
            this.DrawPolygonBtn.TabIndex = 7;
            this.DrawPolygonBtn.UseVisualStyleBackColor = true;
            this.DrawPolygonBtn.Click += new System.EventHandler(this.DrawPolygonBtn_Click);
            // 
            // DrawLineBtn
            // 
            this.DrawLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawLineBtn.Image")));
            this.DrawLineBtn.Location = new System.Drawing.Point(12, 256);
            this.DrawLineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawLineBtn.Name = "DrawLineBtn";
            this.DrawLineBtn.Size = new System.Drawing.Size(56, 39);
            this.DrawLineBtn.TabIndex = 4;
            this.DrawLineBtn.UseVisualStyleBackColor = true;
            this.DrawLineBtn.Click += new System.EventHandler(this.DrawLineBtn_Click);
            // 
            // ChangeClrBtn
            // 
            this.ChangeClrBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChangeClrBtn.Image")));
            this.ChangeClrBtn.Location = new System.Drawing.Point(85, 43);
            this.ChangeClrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeClrBtn.Name = "ChangeClrBtn";
            this.ChangeClrBtn.Size = new System.Drawing.Size(55, 48);
            this.ChangeClrBtn.TabIndex = 3;
            this.ChangeClrBtn.UseVisualStyleBackColor = true;
            this.ChangeClrBtn.Click += new System.EventHandler(this.ChangeClrBtn_Click);
            // 
            // DrawEllipseBtn
            // 
            this.DrawEllipseBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawEllipseBtn.Image")));
            this.DrawEllipseBtn.Location = new System.Drawing.Point(12, 208);
            this.DrawEllipseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawEllipseBtn.Name = "DrawEllipseBtn";
            this.DrawEllipseBtn.Size = new System.Drawing.Size(56, 43);
            this.DrawEllipseBtn.TabIndex = 2;
            this.DrawEllipseBtn.UseVisualStyleBackColor = true;
            this.DrawEllipseBtn.Click += new System.EventHandler(this.DrawEllipseBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SelectBtn.Image = ((System.Drawing.Image)(resources.GetObject("SelectBtn.Image")));
            this.SelectBtn.Location = new System.Drawing.Point(12, 43);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(56, 48);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.UseVisualStyleBackColor = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // DrawRectBtn
            // 
            this.DrawRectBtn.Image = ((System.Drawing.Image)(resources.GetObject("DrawRectBtn.Image")));
            this.DrawRectBtn.Location = new System.Drawing.Point(12, 159);
            this.DrawRectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawRectBtn.Name = "DrawRectBtn";
            this.DrawRectBtn.Size = new System.Drawing.Size(56, 44);
            this.DrawRectBtn.TabIndex = 0;
            this.DrawRectBtn.UseVisualStyleBackColor = true;
            this.DrawRectBtn.Click += new System.EventHandler(this.DrawRectBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(693, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(717, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name";
            // 
            // renameItemToolStripMenuItem
            // 
            this.renameItemToolStripMenuItem.Name = "renameItemToolStripMenuItem";
            this.renameItemToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.renameItemToolStripMenuItem.Text = "Rename item";
            this.renameItemToolStripMenuItem.Click += new System.EventHandler(this.RenameItemToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1160, 539);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findItemBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.breakBtn);
            this.Controls.Add(this.groupBtn);
            this.Controls.Add(this.OpacityBtnLabel);
            this.Controls.Add(this.OpacityChangeBtn);
            this.Controls.Add(this.DrawCurveBtn);
            this.Controls.Add(this.DrawPolygonBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawLineBtn);
            this.Controls.Add(this.ChangeClrBtn);
            this.Controls.Add(this.DrawEllipseBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.DrawRectBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Drawer 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityChangeBtn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawRectBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button DrawEllipseBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChangeClrBtn;
        private System.Windows.Forms.Button DrawLineBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrawPolygonBtn;
        private System.Windows.Forms.Button DrawCurveBtn;
        private System.Windows.Forms.NumericUpDown OpacityChangeBtn;
        private System.Windows.Forms.Label OpacityBtnLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antonioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danielToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button groupBtn;
        private System.Windows.Forms.Button breakBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button findItemBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem renameItemToolStripMenuItem;
    }
}

