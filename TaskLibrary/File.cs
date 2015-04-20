using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;

namespace FancyFileRenamer.TaskLibrary
{
	public class File : INotifyPropertyChanged
	{
		private FileInfo fileinfo;
		private string newFilename;

		public File(string filepath)
		{
			fileinfo = new FileInfo(filepath);
			ExifTagValues = new Dictionary<ExifLib.ExifTags, string>();

			checkForImageFile();

			Filepath = filepath;
			Filename = Path.GetFileName(filepath);
			newFilename = Filename;
			IsValid = true;

			IsSelected = true;
		}

		public bool IsSelected { get; set; }

		public bool IsValid { get; set; }

		public File Self { get { return this; } }

		public string Filepath { get; private set; }

		public string Filename { get; private set; }

		public Dictionary<ExifTags, string> ExifTagValues { get; set; }

		public bool HasExifTags { get; set; }

		public string NewFilename { get { return newFilename; } set { newFilename = value; OnPropertyChanged(); } }

		public DateTime CreationDate { get { return fileinfo.CreationTime; } }

		public DateTime LastWriteDate { get { return fileinfo.LastWriteTime; } }


		private void checkForImageFile()
		{
			if (fileinfo != null && (fileinfo.Extension.ToLower() == ".jpeg" || fileinfo.Extension.ToLower() == ".jpg"))
			{
				using (ExifReader reader = new ExifReader(fileinfo.FullName))
				{
					foreach (var value in Enum.GetValues(typeof(ExifLib.ExifTags)))
					{
						object result = null;

						if (reader.GetTagValue<object>((ExifTags)value, out result))
						{
							ExifTagValues.Add((ExifTags)value, result.ToString());
						}
						else
							ExifTagValues.Add((ExifTags)value, String.Empty);
					}
				}
				HasExifTags = true;
			}
			else
				HasExifTags = false;
		}

		public long? Size
		{
			get
			{
				if (fileinfo != null && fileinfo.Exists)
					return fileinfo.Length;
				else
					return null;
			}
		}

		public void DoRename()
		{
			try
			{
				System.IO.File.Move(Filepath, Path.Combine(Path.GetDirectoryName(Filepath), NewFilename));
			}
			catch
			{
				IsValid = false;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged()
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs("NewFilename"));
		}

		public override string ToString()
		{
			return String.Format("File: <{0}> --> <{1}>", Filename, NewFilename);
		}
	}
}
