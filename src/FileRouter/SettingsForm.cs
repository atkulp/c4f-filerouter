using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileRouter
{
	public partial class SettingsForm : Form
	{
		FileScannerSettings settings;
		FileScanner scanner;

		public SettingsForm()
		{
			InitializeComponent();

			// Initial scanner creation
			settings = FileScannerSettings.GetSettings();
			scanner = new FileScanner(settings);

			scanner.ErrorEncountered += new FileScanner.ErrorEncounteredHandler(scanner_ErrorEncountered);

			// Initialize app based on settings
			fileSystemWatcher1.Path = settings.SourcePath;
			fileSystemWatcher1.IncludeSubdirectories = settings.RecursiveScan;
			fileSystemWatcher1.EnableRaisingEvents = settings.ActiveScan;
			watchNewFilesToolStripMenuItem.Checked = settings.ActiveScan;
		}

		private void ShowSettings()
		{
			// Copy settings to form
			this.sourceTextBox.Text = settings.SourcePath;
			this.recursiveScanCheckbox.Checked = settings.RecursiveScan;

			mappingsListBox.Items.Clear();
			foreach (FileMapping mapping in settings.FileMappings.Values)
			{
				mappingsListBox.Items.Add(mapping);
			}

	        // The form starts out minimized initially to hide
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}

			this.Visible = true;
		}

		private void PerformMatch(string fullPath)
		{
			// Uncomment to see an event when the scan is run
			// notifyIcon1.ShowBalloonTip(3, "New file detected", "Scanning for match...", ToolTipIcon.Info);

			// Changing the notification icon during scans would also
			// provide good feedback (exercise to the reader!)

			// Trigger the file to be matched
			scanner.PerformMatch(fullPath);
		}

		#region Event handlers

		void scanner_ErrorEncountered(string fileName, Exception error)
		{
			notifyIcon1.ShowBalloonTip(
				5,
				"File Router Error",
				"An error was encountered when attempting to move " + fileName + "\n" +
				"[" + error.Message + "]", ToolTipIcon.Error);
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// The user requested the Settings dialog from the icon
			ShowSettings();
		}

		private void watchNewFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (settings.SourcePath.Length == 0)
			{
				MessageBox.Show(
					"Please select a source path in settings first.",
					"Unable to scan",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				// Invert the value to reflect the user's intention
				bool enabled = !watchNewFilesToolStripMenuItem.Checked;

				// Update the settings, the context menu checkbox,
				// and the FileSystemWatcher based on the checkbox state
				settings.ActiveScan = enabled;
				fileSystemWatcher1.EnableRaisingEvents = enabled;
				watchNewFilesToolStripMenuItem.Checked = enabled;

				// This is a change saved with settings
				FileScannerSettings.SaveSettings(settings);
			}
		}

		private void scanNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (settings.SourcePath.Length == 0)
			{
				MessageBox.Show(
					"Please select a source path in settings first.",
					"Unable to scan",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				// Trigger an immediate scan to catch existing files
				scanner.ScanFiles();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// The user has selected exit
            notifyIcon1.Visible = false;
			Application.Exit();
		}

		private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
		{
			PerformMatch(e.FullPath);
		}

		private void fileSystemWatcher1_Renamed(object sender, System.IO.RenamedEventArgs e)
		{
			PerformMatch(e.FullPath);
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			// Copy choices back to settings object
			settings.SourcePath = this.sourceTextBox.Text;
			settings.RecursiveScan = this.recursiveScanCheckbox.Checked;

			// Copy appropriate settigns to FileSystemWatcher
			fileSystemWatcher1.Path = settings.SourcePath;
			fileSystemWatcher1.IncludeSubdirectories = settings.RecursiveScan;

			// Save the changes to disk for consistency
			FileScannerSettings.SaveSettings(settings);

			this.Visible = false;
		}

		private void notifyIcon1_DoubleClick(object sender, EventArgs e)
		{
			ShowSettings();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (expressionTextBox.Text.Length == 0 || destinationTextBox.Text.Length == 0)
			{
				MessageBox.Show(
					"You must fill out expression and destination",
					"Unable to add",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			else
			{
				FileMapping newMapping = new FileMapping();
				newMapping.Expression = expressionTextBox.Text;
				newMapping.DestinationPath = destinationTextBox.Text;

				settings.AddMapping(newMapping);

				mappingsListBox.Items.Add(newMapping.Expression);

				expressionTextBox.Text = "";
				destinationTextBox.Text = "";
			}
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			if (mappingsListBox.SelectedIndex > -1)
			{
				settings.RemoveMapping(mappingsListBox.Text);
				mappingsListBox.Items.RemoveAt(mappingsListBox.SelectedIndex);
				mappingsListBox.SelectedIndex = -1;
			}
		}

		private void sourceBrowseButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = "Select a source folder to scan for new files to route";

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				sourceTextBox.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void destinationBrowseButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = "Select a destination folder for matching files.";

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.destinationTextBox.Text = folderBrowserDialog1.SelectedPath;
			}
		}

#endregion
	}
}