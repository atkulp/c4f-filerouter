using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileRouter
{
	class FileScanner
	{
		FileScannerSettings _settings;

		public delegate void ErrorEncounteredHandler(string fileName, Exception error);

		public event ErrorEncounteredHandler ErrorEncountered;

		public FileScanner(FileScannerSettings settings)
		{
			_settings = settings;
		}

		/// <summary>
		// Perform a scan of all files in a given directory.
		// Each found file is passed to the PerformMatch method for
		// action.
		/// </summary>
		public void ScanFiles()
		{
			SearchOption so;

			if (_settings.RecursiveScan) so = SearchOption.AllDirectories;
			else so = SearchOption.TopDirectoryOnly;

			string[] files = Directory.GetFiles(_settings.SourcePath, "*.*", so);

			foreach( string file in files )
			{
				PerformMatch(file);
			}
		}


		/// <summary>
		/// Any passed file is evaluated against user-entered
		/// expressions.  Any matches are moved to the
		/// corresponding folders.
		/// </summary>
		/// <param name="fileName">Specific file to attempt to match</param>
		public void PerformMatch(string fileName)
		{
			// Isolate the filename from the full path
			string fileNameAlone = Path.GetFileName(fileName);
			string fileNameLower = fileNameAlone.ToLower();

			// Iterate through each mapping
			foreach (FileMapping mapping in _settings.FileMappings.Values)
			{
				// Split each expression at commas
				// (one entry can contain more than pattern) 
				string[] expressions = mapping.Expression.Split(',');
				foreach (string expression in expressions)
				{
					// Move matching files (case-insensitive)
					// Notice that the first matching expression "wins"
					if (fileNameLower.Contains(expression))
					{
						try
						{
							File.Move(fileName,
								Path.Combine(mapping.DestinationPath, fileNameAlone));
							return;
						}
						catch (Exception ex)
						{
							ErrorEncountered(fileNameAlone, ex);
							return;
						}
					}
				}
			}
		}
	}
}
