using FancyFileRenamer.TaskLibrary;
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

namespace FancyFileRenamerWpf.TaskEditControl
{
	/// <summary>
	/// Interaction logic for TaskEditWindow.xaml
	/// </summary>
	public partial class TaskEditWindow : Window, ITaskEditControl
	{
		private ITaskEditUserControl taskEditControl { get; set; }

		public TaskEditWindow()
		{
			InitializeComponent();
		}

		public void SetTaskEditingUserControl(ITaskEditUserControl uc)
		{
			taskEditControl = uc;
			ContentControl.Content = taskEditControl;
			Title = uc.GetTitle();
		}

		private void btnOK_Click(object sender, RoutedEventArgs e)
		{
			taskEditControl.UpdateTaskFromControl();
			DialogResult = true;
			this.Close();
		}

		private void btnAbort_Click(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			this.Close();
		}

		public void UpdateTaskFromControl()
		{
			taskEditControl.UpdateTaskFromControl();
		}

		public void SetTaskToControl(ITask task)
		{
			taskEditControl.SetTaskToControl(task);
		}
	}
}
