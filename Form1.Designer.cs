namespace MarkedWin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.inputPathButton = new System.Windows.Forms.Button();
            this.inputPathTextBox = new System.Windows.Forms.TextBox();
            this.cssPathTextBox = new System.Windows.Forms.TextBox();
            this.cssPathButton = new System.Windows.Forms.Button();
            this.inputPathLabel = new System.Windows.Forms.Label();
            this.cssPathLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.outputPathTextBox = new System.Windows.Forms.TextBox();
            this.outputPathButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.inputPathButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputPathTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cssPathTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cssPathButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputPathLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cssPathLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.errorMessageLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputPathLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputPathTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputPathButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 683);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.webBrowser1, 3);
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 90);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1058, 577);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // inputPathButton
            // 
            this.inputPathButton.AutoSize = true;
            this.inputPathButton.Location = new System.Drawing.Point(1035, 3);
            this.inputPathButton.Name = "inputPathButton";
            this.inputPathButton.Size = new System.Drawing.Size(26, 23);
            this.inputPathButton.TabIndex = 1;
            this.inputPathButton.Text = "...";
            this.inputPathButton.UseVisualStyleBackColor = true;
            this.inputPathButton.Click += new System.EventHandler(this.inputPathButton_Click);
            // 
            // inputPathTextBox
            // 
            this.inputPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPathTextBox.Location = new System.Drawing.Point(91, 3);
            this.inputPathTextBox.Name = "inputPathTextBox";
            this.inputPathTextBox.Size = new System.Drawing.Size(938, 20);
            this.inputPathTextBox.TabIndex = 2;
            this.inputPathTextBox.TextChanged += new System.EventHandler(this.inputPathTextBox_TextChanged);
            // 
            // cssPathTextBox
            // 
            this.cssPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssPathTextBox.Location = new System.Drawing.Point(91, 61);
            this.cssPathTextBox.Name = "cssPathTextBox";
            this.cssPathTextBox.Size = new System.Drawing.Size(938, 20);
            this.cssPathTextBox.TabIndex = 4;
            // 
            // cssPathButton
            // 
            this.cssPathButton.Location = new System.Drawing.Point(1035, 61);
            this.cssPathButton.Name = "cssPathButton";
            this.cssPathButton.Size = new System.Drawing.Size(26, 23);
            this.cssPathButton.TabIndex = 5;
            this.cssPathButton.Text = "...";
            this.cssPathButton.UseVisualStyleBackColor = true;
            this.cssPathButton.Click += new System.EventHandler(this.cssPathButton_Click);
            // 
            // inputPathLabel
            // 
            this.inputPathLabel.AutoSize = true;
            this.inputPathLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.inputPathLabel.Location = new System.Drawing.Point(3, 0);
            this.inputPathLabel.Name = "inputPathLabel";
            this.inputPathLabel.Size = new System.Drawing.Size(82, 29);
            this.inputPathLabel.TabIndex = 6;
            this.inputPathLabel.Text = "Markdown Path";
            this.inputPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cssPathLabel
            // 
            this.cssPathLabel.AutoSize = true;
            this.cssPathLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cssPathLabel.Location = new System.Drawing.Point(3, 58);
            this.cssPathLabel.Name = "cssPathLabel";
            this.cssPathLabel.Size = new System.Drawing.Size(53, 29);
            this.cssPathLabel.TabIndex = 7;
            this.cssPathLabel.Text = "CSS Path";
            this.cssPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.errorMessageLabel, 3);
            this.errorMessageLabel.Location = new System.Drawing.Point(3, 670);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLabel.TabIndex = 3;
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.outputPathLabel.Location = new System.Drawing.Point(3, 29);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(64, 29);
            this.outputPathLabel.TabIndex = 8;
            this.outputPathLabel.Text = "Output Path";
            this.outputPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputPathTextBox
            // 
            this.outputPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPathTextBox.Location = new System.Drawing.Point(91, 32);
            this.outputPathTextBox.Name = "outputPathTextBox";
            this.outputPathTextBox.Size = new System.Drawing.Size(938, 20);
            this.outputPathTextBox.TabIndex = 9;
            this.outputPathTextBox.TextChanged += new System.EventHandler(this.outputPathTextBox_TextChanged);
            // 
            // outputPathButton
            // 
            this.outputPathButton.Location = new System.Drawing.Point(1035, 32);
            this.outputPathButton.Name = "outputPathButton";
            this.outputPathButton.Size = new System.Drawing.Size(26, 23);
            this.outputPathButton.TabIndex = 10;
            this.outputPathButton.Text = "...";
            this.outputPathButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "MarkedWin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button inputPathButton;
        private System.Windows.Forms.TextBox inputPathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox cssPathTextBox;
        private System.Windows.Forms.Button cssPathButton;
        private System.Windows.Forms.Label inputPathLabel;
        private System.Windows.Forms.Label cssPathLabel;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.TextBox outputPathTextBox;
        private System.Windows.Forms.Button outputPathButton;

    }
}

