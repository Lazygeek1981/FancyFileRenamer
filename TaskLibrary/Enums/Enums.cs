using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.Enums
{
	public enum Position { Beginning, End, Custom }

	public enum FileProperty { EXIFDate, CreationDate, ChangeDate, Size }

	public enum ExifDateTimeSorting { DateTime, DateTimeDigitized, DateTimeOriginal, GPSTimestamp }

	public enum FileExtensionChange { ToUpper, ToLower, Custom}
}
