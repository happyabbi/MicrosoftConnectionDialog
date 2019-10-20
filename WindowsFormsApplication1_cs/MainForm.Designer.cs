﻿namespace WindowsFormsApplication1_cs
{
    partial class MainForm
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
            this.CreateNewConnectionButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SelectColumnButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.GenerateSelectStatementButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.ExportToDelimitedFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewConnectionButton
            // 
            this.CreateNewConnectionButton.Location = new System.Drawing.Point(12, 12);
            this.CreateNewConnectionButton.Name = "CreateNewConnectionButton";
            this.CreateNewConnectionButton.Size = new System.Drawing.Size(164, 23);
            this.CreateNewConnectionButton.TabIndex = 0;
            this.CreateNewConnectionButton.Text = "Create connection";
            this.CreateNewConnectionButton.UseVisualStyleBackColor = true;
            this.CreateNewConnectionButton.Click += new System.EventHandler(this.CreateNewConnectionButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(182, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SelectColumnButton
            // 
            this.SelectColumnButton.Enabled = false;
            this.SelectColumnButton.Location = new System.Drawing.Point(12, 41);
            this.SelectColumnButton.Name = "SelectColumnButton";
            this.SelectColumnButton.Size = new System.Drawing.Size(164, 23);
            this.SelectColumnButton.TabIndex = 1;
            this.SelectColumnButton.Text = "Select columns";
            this.SelectColumnButton.UseVisualStyleBackColor = true;
            this.SelectColumnButton.Click += new System.EventHandler(this.SelectColumnButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(358, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 199);
            this.checkedListBox1.TabIndex = 5;
            // 
            // GenerateSelectStatementButton
            // 
            this.GenerateSelectStatementButton.Enabled = false;
            this.GenerateSelectStatementButton.Location = new System.Drawing.Point(12, 70);
            this.GenerateSelectStatementButton.Name = "GenerateSelectStatementButton";
            this.GenerateSelectStatementButton.Size = new System.Drawing.Size(164, 23);
            this.GenerateSelectStatementButton.TabIndex = 2;
            this.GenerateSelectStatementButton.Text = "Generate SQL SELECT";
            this.GenerateSelectStatementButton.UseVisualStyleBackColor = true;
            this.GenerateSelectStatementButton.Click += new System.EventHandler(this.GenerateSelectStatementButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 45);
            this.panel1.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(462, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ExportToDelimitedFileButton
            // 
            this.ExportToDelimitedFileButton.Enabled = false;
            this.ExportToDelimitedFileButton.Location = new System.Drawing.Point(12, 99);
            this.ExportToDelimitedFileButton.Name = "ExportToDelimitedFileButton";
            this.ExportToDelimitedFileButton.Size = new System.Drawing.Size(164, 23);
            this.ExportToDelimitedFileButton.TabIndex = 3;
            this.ExportToDelimitedFileButton.Text = "Export CSV";
            this.ExportToDelimitedFileButton.UseVisualStyleBackColor = true;
            this.ExportToDelimitedFileButton.Click += new System.EventHandler(this.ExportToDelimitedFileButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csv|*.csv|txt|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 262);
            this.Controls.Add(this.ExportToDelimitedFileButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerateSelectStatementButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.SelectColumnButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreateNewConnectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewConnectionButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SelectColumnButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button GenerateSelectStatementButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button ExportToDelimitedFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

