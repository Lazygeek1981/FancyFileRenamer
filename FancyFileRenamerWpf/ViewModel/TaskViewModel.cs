using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamerWpf.ViewModel
{
	public class TaskViewModel
	{
		public ITask Task { get; set; }

		public ITaskEditControl TaskEditControl { get; set; }
	}
}
