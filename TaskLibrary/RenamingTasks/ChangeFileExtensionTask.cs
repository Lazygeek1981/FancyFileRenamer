using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public class ChangeFileExtensionTask : AbstractTask, IRenamingTask
	{
		

		public ChangeFileExtensionTask()
		{
			NewExtension = String.Empty;
			ChangeMode = FileExtensionChange.Custom;
		}

		public string NewExtension { get; set; }
		public FileExtensionChange ChangeMode { get; set; }

		public void ApplyOn(File datei)
		{
			string newExtension = System.IO.Path.GetExtension(datei.Filename);

			switch (ChangeMode)
			{ 
				case FileExtensionChange.Custom:
					if (NewExtension.StartsWith("."))
						newExtension = NewExtension.Replace(".", "");					
					break;
				case FileExtensionChange.ToLower:
					newExtension = newExtension.ToLower();
					break;
				case FileExtensionChange.ToUpper:
					newExtension = newExtension.ToUpper();
					break;
			}

			datei.NewFilename = System.IO.Path.ChangeExtension(datei.NewFilename, newExtension);
		}

		public IRenamingTask Self
		{
			get { return this; }
		}

		public override string Description
		{
			get { return String.Format("CHANGE FILE EXTENSION"); }
		}

		public override string NameInTaskSelectionList
		{
			get { return "Change file extension"; }
		}

		public IRenamingTask GetNewInstance()
		{
			return new ChangeFileExtensionTask();
		}

		public void ResetTask()
		{
			//nothing todo here!
		}
	}
}
