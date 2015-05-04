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
using System.Windows.Shapes;
using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.Enums;
using FancyFileRenamer.TaskLibrary.RenamingTasks;

namespace FancyFileRenamerWpf.TaskEditControl
{
	/// <summary>
	/// Interaction logic for FilePropertyTaskEditControl.xaml
	/// </summary>
	public partial class FilePropertyTaskEditControl : Window, ITaskEditControl
	{
		private bool isLatched = false;
		public FilePropertyTask Task { get; set; }



		public FilePropertyTaskEditControl()
		{
			isLatched = true;
			InitializeComponent();
			isLatched = false;
		}

		public void UpdateTaskFromControl()
		{
			if (isLatched)
				return;

			Task.CustomPosition = textCustomPosition.Text.ToIntegerSafely(0);
			Task.ExifTag = (ExifDateTimeSorting)comboEXIF.SelectedIndex;
			Task.Position = (Position)comboPosition.SelectedIndex;
			Task.SelectedProperty = (FileProperty)comboProperty.SelectedIndex;
			Task.PropertyFormatString = textFormatString.Text;
		}

		public void SetTaskToControl(ITask task)
		{
			isLatched = true;

			Task = task.As<FilePropertyTask>();

			textCustomPosition.Text = Task.CustomPosition.ToString();
			comboPosition.SelectedIndex = (int)Task.Position;
			comboProperty.SelectedIndex = (int)Task.SelectedProperty;
			comboEXIF.SelectedIndex = (int)Task.ExifTag;
			textFormatString.Text = Task.PropertyFormatString;

			isLatched = false;
		}

		private void buttonOK_Click(object sender, RoutedEventArgs e)
		{
			UpdateTaskFromControl();
			DialogResult = true;
		}

		private void textChanged(object sender, TextChangedEventArgs e)
		{
			UpdateTaskFromControl();
		}
		
		private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateTaskFromControl();
		}
	}
}
