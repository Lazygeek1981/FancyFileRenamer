using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.Enums;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FancyFileRenamerWpf.TaskEditControl
{
	/// <summary>
	/// Interaction logic for ChangeFileExtensionUserControl.xaml
	/// </summary>
	public partial class ChangeFileExtensionUserControl : UserControl, ITaskEditUserControl
	{
		private ChangeFileExtensionTask task { get; set; }

		public ChangeFileExtensionUserControl()
		{
			InitializeComponent();
		}

		public string GetTitle()
		{
			return "Change File Extension";
		}


		public bool CheckIfCanClose()
		{
			return true;
		}

		public void UpdateTaskFromControl()
		{
			if (radToUpper.IsChecked.GetValueOrDefault())
				task.ChangeMode = FileExtensionChange.ToUpper;
			else if (radToLower.IsChecked.GetValueOrDefault())
				task.ChangeMode = FileExtensionChange.ToLower;
			else if (radToCustom.IsChecked.GetValueOrDefault())
			{
				task.ChangeMode = FileExtensionChange.Custom;
				task.NewExtension = txtCustomExtension.Text;
			}
		}

		public void SetTaskToControl(ITask changeExtensionTask)
		{
			this.task = (ChangeFileExtensionTask)changeExtensionTask;

			switch (task.ChangeMode)
			{
				case FileExtensionChange.Custom:
					radToCustom.IsChecked = true;
					txtCustomExtension.Text = task.NewExtension;
					break;
				case FileExtensionChange.ToLower:
					radToLower.IsChecked = true;
					break;
				case FileExtensionChange.ToUpper:
					radToUpper.IsChecked = true;
					break;
			}
		}
	}
}
