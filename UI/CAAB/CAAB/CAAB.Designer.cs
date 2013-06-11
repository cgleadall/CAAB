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
            this.SelectSourceButton = new System.Windows.Forms.Button();
            this.BeginCopy = new System.Windows.Forms.Button();
            this.SourceFolderLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DestinationFolderLabel = new System.Windows.Forms.Label();
            this.BackgroundCopyWorker = new System.ComponentModel.BackgroundWorker();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectDestinationButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // DestinationFolderLabel
            // 
            this.DestinationFolderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DestinationFolderLabel.Location = new System.Drawing.Point(3, 16);
            this.DestinationFolderLabel.Name = "DestinationFolderLabel";
            this.DestinationFolderLabel.Size = new System.Drawing.Size(320, 13);
            this.DestinationFolderLabel.TabIndex = 1;
            this.DestinationFolderLabel.Text = "e:\\backups\\{0}";
            // 
            // BackgroundCopyWorker
            // 
            this.BackgroundCopyWorker.WorkerReportsProgress = true;
            this.BackgroundCopyWorker.WorkerSupportsCancellation = true;
            // 
            // FolderDialog
            // 
            this.FolderDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
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
            this.groupBox2.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker BackgroundCopyWorker;
        private System.Windows.Forms.Button SelectSourceButton;
        private System.Windows.Forms.Label DestinationFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Button SelectDestinationButton;
    }
}

