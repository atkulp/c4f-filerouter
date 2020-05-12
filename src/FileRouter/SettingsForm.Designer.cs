namespace FileRouter
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.label1 = new System.Windows.Forms.Label();
			this.sourceTextBox = new System.Windows.Forms.TextBox();
			this.sourceBrowseButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.mappingsListBox = new System.Windows.Forms.ListBox();
			this.expressionTextBox = new System.Windows.Forms.TextBox();
			this.destinationTextBox = new System.Windows.Forms.TextBox();
			this.destinationBrowseButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.extToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.recursiveScanCheckbox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.watchNewFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Source";
			// 
			// sourceTextBox
			// 
			this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.sourceTextBox.Location = new System.Drawing.Point(68, 12);
			this.sourceTextBox.Name = "sourceTextBox";
			this.sourceTextBox.Size = new System.Drawing.Size(231, 20);
			this.sourceTextBox.TabIndex = 1;
			this.extToolTip.SetToolTip(this.sourceTextBox, "This is the path to the directory to monitor.");
			// 
			// sourceBrowseButton
			// 
			this.sourceBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceBrowseButton.Location = new System.Drawing.Point(305, 10);
			this.sourceBrowseButton.Name = "sourceBrowseButton";
			this.sourceBrowseButton.Size = new System.Drawing.Size(29, 23);
			this.sourceBrowseButton.TabIndex = 2;
			this.sourceBrowseButton.Text = "&...";
			this.extToolTip.SetToolTip(this.sourceBrowseButton, "Click here to browse for the source directory");
			this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "&Mappings";
			// 
			// mappingsListBox
			// 
			this.mappingsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.mappingsListBox.FormattingEnabled = true;
			this.mappingsListBox.Location = new System.Drawing.Point(69, 58);
			this.mappingsListBox.Name = "mappingsListBox";
			this.mappingsListBox.Size = new System.Drawing.Size(265, 134);
			this.mappingsListBox.TabIndex = 4;
			// 
			// expressionTextBox
			// 
			this.expressionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.expressionTextBox.Location = new System.Drawing.Point(115, 212);
			this.expressionTextBox.Name = "expressionTextBox";
			this.expressionTextBox.Size = new System.Drawing.Size(166, 20);
			this.expressionTextBox.TabIndex = 6;
			this.extToolTip.SetToolTip(this.expressionTextBox, resources.GetString("expressionTextBox.ToolTip"));
			// 
			// destinationTextBox
			// 
			this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.destinationTextBox.Location = new System.Drawing.Point(116, 244);
			this.destinationTextBox.Name = "destinationTextBox";
			this.destinationTextBox.Size = new System.Drawing.Size(182, 20);
			this.destinationTextBox.TabIndex = 8;
			this.extToolTip.SetToolTip(this.destinationTextBox, "This is the destination for files matching the current expression.");
			// 
			// destinationBrowseButton
			// 
			this.destinationBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.destinationBrowseButton.Location = new System.Drawing.Point(304, 242);
			this.destinationBrowseButton.Name = "destinationBrowseButton";
			this.destinationBrowseButton.Size = new System.Drawing.Size(29, 23);
			this.destinationBrowseButton.TabIndex = 9;
			this.destinationBrowseButton.Text = "...";
			this.extToolTip.SetToolTip(this.destinationBrowseButton, "Click here to browse for the destination directory");
			this.destinationBrowseButton.Click += new System.EventHandler(this.destinationBrowseButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(4, 130);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(59, 23);
			this.removeButton.TabIndex = 10;
			this.removeButton.Text = "&Remove";
			this.extToolTip.SetToolTip(this.removeButton, "Click to remove the current selected mapping.");
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// recursiveScanCheckbox
			// 
			this.recursiveScanCheckbox.AutoSize = true;
			this.recursiveScanCheckbox.Location = new System.Drawing.Point(69, 38);
			this.recursiveScanCheckbox.Name = "recursiveScanCheckbox";
			this.recursiveScanCheckbox.Size = new System.Drawing.Size(178, 17);
			this.recursiveScanCheckbox.TabIndex = 15;
			this.recursiveScanCheckbox.Text = "Scan source directory recursively";
			this.extToolTip.SetToolTip(this.recursiveScanCheckbox, "Check this box to scan not only the selected folder, but\r\nalso any nested folders" +
					" (subfolders).");
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "&Expression";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "&Destination";
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.Location = new System.Drawing.Point(287, 212);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(46, 23);
			this.addButton.TabIndex = 13;
			this.addButton.Text = "&Add";
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.closeButton.Location = new System.Drawing.Point(129, 278);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 14;
			this.closeButton.Text = "&Close";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "File Router";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Enabled = true;
			this.contextMenuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.watchNewFilesToolStripMenuItem,
            this.scanNowToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Location = new System.Drawing.Point(25, 66);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.contextMenuStrip1.Size = new System.Drawing.Size(143, 104);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Text = "Settings...";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// watchNewFilesToolStripMenuItem
			// 
			this.watchNewFilesToolStripMenuItem.Name = "watchNewFilesToolStripMenuItem";
			this.watchNewFilesToolStripMenuItem.Text = "Watch New Files";
			this.watchNewFilesToolStripMenuItem.Click += new System.EventHandler(this.watchNewFilesToolStripMenuItem_Click);
			// 
			// scanNowToolStripMenuItem
			// 
			this.scanNowToolStripMenuItem.Name = "scanNowToolStripMenuItem";
			this.scanNowToolStripMenuItem.Text = "Scan Now";
			this.scanNowToolStripMenuItem.Click += new System.EventHandler(this.scanNowToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
			this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 313);
			this.ControlBox = false;
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.recursiveScanCheckbox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.mappingsListBox);
			this.Controls.Add(this.destinationBrowseButton);
			this.Controls.Add(this.destinationTextBox);
			this.Controls.Add(this.expressionTextBox);
			this.Controls.Add(this.sourceBrowseButton);
			this.Controls.Add(this.sourceTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.Text = "File Router Settings";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.Button sourceBrowseButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox mappingsListBox;
		private System.Windows.Forms.TextBox expressionTextBox;
		private System.Windows.Forms.TextBox destinationTextBox;
		private System.Windows.Forms.Button destinationBrowseButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.ToolTip extToolTip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scanNowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem watchNewFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.CheckBox recursiveScanCheckbox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

