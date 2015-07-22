using FancyFileRenamer.TaskLibrary.Conditions;
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
	/// Interaction logic for ConditionalTaskEditControl.xaml
	/// </summary>
	public partial class ConditionalTaskEditControl : UserControl, ITaskEditUserControl
	{
		private ConditionalTask task;

		public ConditionalTaskEditControl()
		{
			InitializeComponent();
		}

		private void btnAddCondition_Click(object sender, RoutedEventArgs e)
		{
			FilePropertyCondition condition = new FilePropertyCondition();
			condition.BooleanRealtion = FancyFileRenamer.TaskLibrary.Enums.BooleanRelation.Equal;
			condition.FileProperty = FancyFileRenamer.TaskLibrary.Enums.FileProperty.EXIFDate;
			condition.Value = "";
			
		}

		public string GetTitle()
		{
			return "Conditional Task";
		}

		public bool CheckIfCanClose()
		{
			return true;
		}

		public void UpdateTaskFromControl()
		{
			
		}

		public void SetTaskToControl(FancyFileRenamer.TaskLibrary.ITask task)
		{
			this.task = (ConditionalTask)task;
		}
	}
}
