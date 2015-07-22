using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.PropertyChangingTasks
{
	public class EXIFDateOffsetTask : ITask
	{
		public string NameInTaskSelectionList
		{
			get { throw new NotImplementedException(); }
		}

		public string Description
		{
			get { throw new NotImplementedException(); }
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	}
}
