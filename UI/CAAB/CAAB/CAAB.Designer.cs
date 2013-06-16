namespace CAAB
{
    partial class CAAB
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LastCopyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WorkingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderDetailsPanel = new System.Windows.Forms.Panel();
            this.TotalMBLabel = new System.Windows.Forms.Label();
            this.FileCountLabel = new System.Windows.Forms.Label();
            this.FolderCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSourceButton = new System.Windows.Forms.Button();
            this.BeginCopy = new System.Windows.Forms.Button();
            this.SourceFolderLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DriveDetailsPanel = new System.Windows.Forms.Panel();
            this.FreeSpaceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectDestinationButton = new System.Windows.Forms.Button();
            this.DestinationFolderLabel = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TotalUsedSpaceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VolumeNameLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FolderDetailsPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DriveDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LastCopyStatusLabel,
            this.WorkingStatusLabel,
            this.StatusProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(639, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LastCopyStatusLabel
            // 
            this.LastCopyStatusLabel.Name = "LastCopyStatusLabel";
            this.LastCopyStatusLabel.Size = new System.Drawing.Size(62, 17);
            this.LastCopyStatusLabel.Text = "Last Copy:";
            // 
            // WorkingStatusLabel
            // 
            this.WorkingStatusLabel.Name = "WorkingStatusLabel";
            this.WorkingStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.WorkingStatusLabel.Text = "working...";
            this.WorkingStatusLabel.Visible = false;
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 16);
            this.StatusProgressBar.Step = 1;
            this.StatusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StatusProgressBar.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(639, 312);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FolderDetailsPanel);
            this.groupBox1.Controls.Add(this.SelectSourceButton);
            this.groupBox1.Controls.Add(this.BeginCopy);
            this.groupBox1.Controls.Add(this.SourceFolderLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // FolderDetailsPanel
            // 
            this.FolderDetailsPanel.Controls.Add(this.TotalMBLabel);
            this.FolderDetailsPanel.Controls.Add(this.FileCountLabel);
            this.FolderDetailsPanel.Controls.Add(this.FolderCountLabel);
            this.FolderDetailsPanel.Controls.Add(this.label4);
            this.FolderDetailsPanel.Controls.Add(this.label3);
            this.FolderDetailsPanel.Controls.Add(this.label2);
            this.FolderDetailsPanel.Controls.Add(this.label1);
            this.FolderDetailsPanel.Location = new System.Drawing.Point(6, 63);
            this.FolderDetailsPanel.Name = "FolderDetailsPanel";
            this.FolderDetailsPanel.Size = new System.Drawing.Size(297, 99);
            this.FolderDetailsPanel.TabIndex = 3;
            this.FolderDetailsPanel.Visible = false;
            // 
            // TotalMBLabel
            // 
            this.TotalMBLabel.Location = new System.Drawing.Point(128, 66);
            this.TotalMBLabel.Name = "TotalMBLabel";
            this.TotalMBLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalMBLabel.TabIndex = 4;
            this.TotalMBLabel.Text = "MB";
            this.TotalMBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileCountLabel
            // 
            this.FileCountLabel.Location = new System.Drawing.Point(128, 43);
            this.FileCountLabel.Name = "FileCountLabel";
            this.FileCountLabel.Size = new System.Drawing.Size(100, 23);
            this.FileCountLabel.TabIndex = 4;
            this.FileCountLabel.Text = "files";
            this.FileCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FolderCountLabel
            // 
            this.FolderCountLabel.Location = new System.Drawing.Point(129, 20);
            this.FolderCountLabel.Name = "FolderCountLabel";
            this.FolderCountLabel.Size = new System.Drawing.Size(100, 23);
            this.FolderCountLabel.TabIndex = 4;
            this.FolderCountLabel.Text = "folders";
            this.FolderCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Number of MB:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Files:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Folders:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectSourceButton
            // 
            this.SelectSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSourceButton.Location = new System.Drawing.Point(6, 33);
            this.SelectSourceButton.Name = "SelectSourceButton";
            this.SelectSourceButton.Size = new System.Drawing.Size(297, 23);
            this.SelectSourceButton.TabIndex = 2;
            this.SelectSourceButton.Text = "Select Source Folder";
            this.SelectSourceButton.UseVisualStyleBackColor = true;
            this.SelectSourceButton.Click += new System.EventHandler(this.SelectSourceButtonClick);
            // 
            // BeginCopy
            // 
            this.BeginCopy.Location = new System.Drawing.Point(103, 283);
            this.BeginCopy.Name = "BeginCopy";
            this.BeginCopy.Size = new System.Drawing.Size(75, 23);
            this.BeginCopy.TabIndex = 1;
            this.BeginCopy.Text = "Copy";
            this.BeginCopy.UseVisualStyleBackColor = true;
            this.BeginCopy.Click += new System.EventHandler(this.BeginCopyClick);
            // 
            // SourceFolderLabel
            // 
            this.SourceFolderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SourceFolderLabel.Location = new System.Drawing.Point(3, 16);
            this.SourceFolderLabel.Name = "SourceFolderLabel";
            this.SourceFolderLabel.Size = new System.Drawing.Size(303, 13);
            this.SourceFolderLabel.TabIndex = 0;
            this.SourceFolderLabel.Text = "c:\\users\\{0}\\Documents";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DriveDetailsPanel);
            this.groupBox2.Controls.Add(this.SelectDestinationButton);
            this.groupBox2.Controls.Add(this.DestinationFolderLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 312);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // DriveDetailsPanel
            // 
            this.DriveDetailsPanel.Controls.Add(this.VolumeNameLabel);
            this.DriveDetailsPanel.Controls.Add(this.TotalUsedSpaceLabel);
            this.DriveDetailsPanel.Controls.Add(this.label6);
            this.DriveDetailsPanel.Controls.Add(this.FreeSpaceLabel);
            this.DriveDetailsPanel.Controls.Add(this.label5);
            this.DriveDetailsPanel.Controls.Add(this.label10);
            this.DriveDetailsPanel.Controls.Add(this.label11);
            this.DriveDetailsPanel.Location = new System.Drawing.Point(17, 63);
            this.DriveDetailsPanel.Name = "DriveDetailsPanel";
            this.DriveDetailsPanel.Size = new System.Drawing.Size(297, 99);
            this.DriveDetailsPanel.TabIndex = 4;
            this.DriveDetailsPanel.Visible = false;
            // 
            // FreeSpaceLabel
            // 
            this.FreeSpaceLabel.Location = new System.Drawing.Point(129, 20);
            this.FreeSpaceLabel.Name = "FreeSpaceLabel";
            this.FreeSpaceLabel.Size = new System.Drawing.Size(100, 23);
            this.FreeSpaceLabel.TabIndex = 4;
            this.FreeSpaceLabel.Text = "freespace MB";
            this.FreeSpaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(7, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Used:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Free Space:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Drive Details";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDestinationButton
            // 
            this.SelectDestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDestinationButton.Location = new System.Drawing.Point(6, 33);
            this.SelectDestinationButton.Name = "SelectDestinationButton";
            this.SelectDestinationButton.Size = new System.Drawing.Size(308, 23);
            this.SelectDestinationButton.TabIndex = 3;
            this.SelectDestinationButton.Text = "Select Destination Folder";
            this.SelectDestinationButton.UseVisualStyleBackColor = true;
            this.SelectDestinationButton.Click += new System.EventHandler(this.SelectDestinationButtonClick);
            // 
            // DestinationFolderLabel
            // 
            this.DestinationFolderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DestinationFolderLabel.Location = new System.Drawing.Point(3, 16);
            this.DestinationFolderLabel.Name = "DestinationFolderLabel";
            this.DestinationFolderLabel.Size = new System.Drawing.Size(320, 13);
            this.DestinationFolderLabel.TabIndex = 1;
            this.DestinationFolderLabel.Text = "e:\\backups\\{0}";
            // 
            // FolderDialog
            // 
            this.FolderDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // TotalUsedSpaceLabel
            // 
            this.TotalUsedSpaceLabel.Location = new System.Drawing.Point(129, 43);
            this.TotalUsedSpaceLabel.Name = "TotalUsedSpaceLabel";
            this.TotalUsedSpaceLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalUsedSpaceLabel.TabIndex = 4;
            this.TotalUsedSpaceLabel.Text = "Used MB";
            this.TotalUsedSpaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Volume Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VolumeNameLabel
            // 
            this.VolumeNameLabel.Location = new System.Drawing.Point(128, 66);
            this.VolumeNameLabel.Name = "VolumeNameLabel";
            this.VolumeNameLabel.Size = new System.Drawing.Size(100, 23);
            this.VolumeNameLabel.TabIndex = 4;
            this.VolumeNameLabel.Text = "Name";
            this.VolumeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CAAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 358);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CAAB";
            this.Text = "CAAB";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.FolderDetailsPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.DriveDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SourceFolderLabel;
        private System.Windows.Forms.ToolStripStatusLabel LastCopyStatusLabel;
        private System.Windows.Forms.Button BeginCopy;
        private System.Windows.Forms.ToolStripStatusLabel WorkingStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.Button SelectSourceButton;
        private System.Windows.Forms.Label DestinationFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Button SelectDestinationButton;
        private System.Windows.Forms.Panel FolderDetailsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalMBLabel;
        private System.Windows.Forms.Label FileCountLabel;
        private System.Windows.Forms.Label FolderCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DriveDetailsPanel;
        private System.Windows.Forms.Label FreeSpaceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VolumeNameLabel;
        private System.Windows.Forms.Label TotalUsedSpaceLabel;
        private System.Windows.Forms.Label label6;
    }
}

