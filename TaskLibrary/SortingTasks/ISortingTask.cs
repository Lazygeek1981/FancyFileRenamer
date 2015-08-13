using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
	public interface ISortingTask : IComparer<FancyFile>, ITask
	{
		SortingOrder Ordering { get; set; }
	}
}
