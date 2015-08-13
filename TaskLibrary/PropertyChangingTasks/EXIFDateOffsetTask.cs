using FancyFileRenamer.TaskLibrary.Enums;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.PropertyChangingTasks
{
	public class EXIFDateOffsetTask : AbstractTask, IRenamingTask
	{
		public ExifDateTimeProperty ExifProperty = ExifDateTimeProperty.DateTimeDigitized;

		public TimeSpan TimeOffset { get; set; }

		public override string NameInTaskSelectionList
		{
			get { return "EXIF Date Offset"; }
		}

		public override string Description
		{
			get { return "Change EXIF Dates with offset"; }
		}

		

		public override ITask GetNewInstance()
		{
			return new EXIFDateOffsetTask();
		}

		public void ApplyOn(FancyFile datei)
		{
			if (datei.HasExifTags)
			{
				datei.ExifTagValues[ExifLib.ExifTags.DateTimeDigitized] = "";
			}
		}

		public IRenamingTask Self
		{
			get { return this; }
		}

		public void ResetTask()
		{
			
		}
	}
}
