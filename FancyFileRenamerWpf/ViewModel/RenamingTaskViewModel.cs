using FancyFileRenamer.TaskLibrary.RenamingTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FancyFileRenamerWpf.ViewModel
{
	public class RenamingTaskViewModel
	{
		public IRenamingTask RenamingTask { get; set; }

		public UserControl EditingControl { get; set; }
	}
}
