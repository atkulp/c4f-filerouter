using System;
using System.Collections.Generic;
using System.Text;

namespace FileRouter
{
	[Serializable]
	class FileMapping
	{
		private string _expression;
		private string _destinationPath;

		/// <summary>
		/// The expression to match
		/// </summary>
		public string Expression
		{
			get { return _expression; }
			set { _expression = value; }
		}

		/// <summary>
		/// The path to which to copy matching files
		/// </summary>
		public string DestinationPath
		{
			get { return _destinationPath; }
			set { _destinationPath = value; }
		}

		public override string ToString()
		{
			return _expression;
		}
	}
}
