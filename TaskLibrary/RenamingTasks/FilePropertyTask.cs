using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public class FilePropertyTask : AbstractTask, IRenamingTask
	{
		#region IRenamingTask Members

		public void ApplyOn(File datei)
		{
			throw new NotImplementedException();
		}

		public IRenamingTask Self
		{
			get { throw new NotImplementedException(); }
		}

		public IRenamingTask GetNewInstance()
		{
			throw new NotImplementedException();
		}

		public void ResetTask()
		{
			throw new NotImplementedException();
		}

		#endregion

		public override string NameInTaskSelectionList
		{
			get { throw new NotImplementedException(); }
		}

		public override string Description
		{
			get { throw new NotImplementedException(); }
		}
	}
}
