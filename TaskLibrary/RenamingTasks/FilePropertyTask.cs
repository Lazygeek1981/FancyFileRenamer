using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.Enums;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public class FilePropertyTask : AbstractTask, IRenamingTask
	{
		public FileProperty SelectedProperty { get; set; }

		public ExifDateTimeSorting ExifTag { get; set; }

		public int CustomPosition { get; set; }

		public Position Position { get; set; }

		public string PropertyFormatString { get; set; }

		public FilePropertyTask()
		{
			SelectedProperty = FileProperty.ChangeDate;
			ExifTag = ExifDateTimeSorting.DateTime;
			CustomPosition = 0;
			Position = Enums.Position.Beginning;
			PropertyFormatString = String.Empty;
		}

		public void ApplyOn(File datei)
		{
			string propertyText = String.Empty;

			switch (SelectedProperty)
			{
				case FileProperty.ChangeDate:
					propertyText = "NOT IMPLEMENTED";
					break;
				case FileProperty.CreationDate:
					propertyText = datei.CreationDate.ToString(PropertyFormatString);
					break;
				case FileProperty.EXIFDate:
					DateTime? exifDate = null;
					switch (ExifTag)
					{
						case ExifDateTimeSorting.DateTime:
							exifDate = getExifDate(datei, ExifLib.ExifTags.DateTime);
							break;
						case ExifDateTimeSorting.DateTimeDigitized:
							exifDate = getExifDate(datei, ExifLib.ExifTags.DateTimeDigitized);
							break;
						case ExifDateTimeSorting.DateTimeOriginal:
							exifDate = getExifDate(datei, ExifLib.ExifTags.DateTimeOriginal);
							break;
						case ExifDateTimeSorting.GPSTimestamp:
							exifDate = getExifDate(datei, ExifLib.ExifTags.GPSTimestamp);
							break;
					}

					if (exifDate.HasValue)
						propertyText = exifDate.Value.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss");
					else
						propertyText = "[EMPTY]";
					break;

				case FileProperty.Size:
					propertyText = datei.Size.GetValueOrDefault().ToString(PropertyFormatString);
					break;
			}

			switch (Position)
			{
				case Enums.Position.Beginning:
					datei.NewFilename = propertyText + datei.NewFilename;
					break;
				case Enums.Position.End:
					datei.NewFilename = Path.GetFileNameWithoutExtension(datei.NewFilename) + propertyText + Path.GetExtension(datei.NewFilename);
					break;
				case Enums.Position.Custom:
					datei.NewFilename = datei.NewFilename.Insert(CustomPosition, propertyText);
					break;
			}
		}	

		private DateTime? getExifDate(File datei, ExifLib.ExifTags tag)
		{
			if (datei.ExifTagValues.Count == 0)
				return null;

			DateTime dateTime = new DateTime();
			if (DateTime.TryParseExact(datei.ExifTagValues[tag], "yyyy:MM:dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime))
			{
				return dateTime;
			}
			else
				return null;
		}

		public IRenamingTask Self
		{
			get { return this; }
		}

		public IRenamingTask GetNewInstance()
		{
			return new FilePropertyTask();
		}

		public void ResetTask()
		{

		}

		public override string NameInTaskSelectionList
		{
			get { return "File Property Task"; }
		}

		public override string Description
		{
			get { return "Inserts a file property into the filename"; }
		}
	}
}
