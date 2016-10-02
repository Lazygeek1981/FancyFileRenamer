using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIDummies
{
	public class ProjectViewModel
	{
		public string Title { get; set; }

		public ObservableCollection<TaskViewModel> Tasks { get; set; }

	}
}
