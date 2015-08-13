using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;
using FancyFileRenamer.TaskLibrary.Enums;
using System.Globalization;

namespace FancyFileRenamer.TaskLibrary
{
	public class FancyFile : INotifyPropertyChanged
	{
		public static Dictionary<ExifLib.ExifTags, ExifDateTimeProperty> ExifLibTagToExifDateTimeEnumProperty = new Dictionary<ExifTags, ExifDateTimeProperty>
		{
			{ExifTags.DateTime, ExifDateTimeProperty.DateTime},
			{ExifTags.DateTimeDigitized, ExifDateTimeProperty.DateTimeDigitized},
			{ExifTags.DateTimeOriginal, ExifDateTimeProperty.DateTimeOriginal},
			{ExifTags.GPSTimestamp, ExifDateTimeProperty.GPSTimestamp}
		};

		private FileInfo fileinfo;
		private string newFilename;
		private bool isSelected = true;

		public FancyFile(string filepath)
		{
			fileinfo = new FileInfo(filepath);
			ExifTagValues = new Dictionary<ExifLib.ExifTags, string>();
			ExifTagDateValues = new Dictionary<ExifDateTimeProperty, DateTime?>();

			checkForImageFile();

			Filepath = filepath;
			Filename = Path.GetFileName(filepath);
			newFilename = Filename;
			IsValid = true;

			IsSelected = true;
		}


		public bool IsSelected //{ get; set; }
		{
			get { return isSelected; }
			set
			{
				if (isSelected == value)
					return;
				isSelected = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("IsSelected"));
			}
		}

		public bool IsValid { get; set; }

		public FancyFile Self { get { return this; } }

		public string Filepath { get; private set; }

		public string Filename { get; private set; }

		public Dictionary<ExifDateTimeProperty, DateTime?> ExifTagDateValues { get; set; }

		public Dictionary<ExifTags, string> ExifTagValues { get; set; }

		public bool HasExifTags { get; set; }

		public string NewFilename { get { return newFilename; } set { newFilename = value; OnPropertyChanged(); } }

		public DateTime CreationDate { get { return fileinfo.CreationTime; } }

		public DateTime ChangeDate { get { return fileinfo.LastWriteTime; } }

		public DateTime LastWriteDate { get { return fileinfo.LastWriteTime; } }

		private void checkForImageFile()
		{
			if (fileinfo != null && (fileinfo.Extension.ToLower() == ".jpeg" || fileinfo.Extension.ToLower() == ".jpg"))
			{
				HasExifTags = true;
				using (ExifReader reader = new ExifReader(fileinfo.FullName))
				{
					foreach (var value in Enum.GetValues(typeof(ExifLib.ExifTags)))
					{
						ExifTags currentTag = (ExifTags)value;
						object result = null;


						if (reader.GetTagValue<object>(currentTag, out result))
						{
							ExifTagValues.Add(currentTag, result.ToString());

							if (ExifLibTagToExifDateTimeEnumProperty.ContainsKey(currentTag))
								ExifTagDateValues.Add(ExifLibTagToExifDateTimeEnumProperty[currentTag], getExifDate(currentTag));
						}
						else
							ExifTagValues.Add(currentTag, String.Empty);
					}
				}
			}
			else
				HasExifTags = false;
		}

		private DateTime? getExifDate(ExifTags tag)
		{
			if (!HasExifTags)
				return null;

			DateTime dateTime = new DateTime();
			if (DateTime.TryParseExact(ExifTagValues[tag], "yyyy:MM:dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime))
			{
				return dateTime;
			}
			else
				return null;
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
