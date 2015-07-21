using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public interface ICondition
	{
		bool IsFulFilled();
		ICondition GetNewInstance();
	}
}
