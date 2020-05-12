using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileRouter
{
	[Serializable]
	class FileScannerSettings
	{
		private static string SETTINGS_FILENAME = "FileRouter.settings";

		private bool _activeScan = false;
		private string _sourcePath = string.Empty;
		private bool _recursiveScan = false;
		private Dictionary<string, FileMapping> _mappings = new Dictionary<string, FileMapping>();

		#region File IO (Reading/Writing Settings)

		/// <summary>
		/// Deserialize settings object from storage
		/// </summary>
		/// <returns>Retrieved settings object, if found, otherwise new.</returns>
		public static FileScannerSettings GetSettings()
		{
			Stream str = null;

			try
			{
				str = File.Open(SETTINGS_FILENAME, FileMode.Open);
				BinaryFormatter bf = new BinaryFormatter();
				FileScannerSettings fs = (FileScannerSettings)bf.Deserialize(str);

				return fs;
			}
			catch
			{
				// Most likely saved file does not exist
				return new FileScannerSettings();
			}
			finally
			{
				if (str != null) str.Close();
			}

		}

		/// <summary>
		/// Serialize the settings to disk
		/// </summary>
		/// <param name="fs">Savings to serialize</param>
		public static void SaveSettings(FileScannerSettings fs)
		{
			Stream str = File.Open(SETTINGS_FILENAME, FileMode.Create);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(str, fs);
			str.Close();
		}

		#endregion

		#region Manage list of mappings

		public void AddMapping(FileMapping newMapping)
		{
			_mappings.Add(newMapping.Expression, newMapping);
		}

		public void RemoveMapping(string mappingName)
		{
			_mappings.Remove(mappingName);
		}

		public FileMapping GetMapping(string mappingName)
		{
			return _mappings[mappingName];
		}

		#endregion

		#region Public Properties

		public Dictionary<string, FileMapping> FileMappings
		{
			get { return _mappings; }
		}

		public string SourcePath
		{
			get { return _sourcePath; }
			set { _sourcePath = value; }
		}

		public bool ActiveScan
		{
			get { return _activeScan; }
			set { _activeScan = value; }
		}

		public bool RecursiveScan
		{
			get { return _recursiveScan; }
			set { _recursiveScan = value; }
		}

		#endregion

	}
}
