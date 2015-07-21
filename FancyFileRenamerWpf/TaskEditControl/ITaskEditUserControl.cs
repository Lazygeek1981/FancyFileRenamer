using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamerWpf.TaskEditControl
{
	public interface ITaskEditUserControl : FancyFileRenamer.TaskLibrary.ITaskEditControl
	{
		string GetTitle();
		bool CheckIfCanClose();	
	}
}
