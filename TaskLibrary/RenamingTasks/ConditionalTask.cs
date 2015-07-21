using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public class ConditionalTask : IRenamingTask
	{
		public ConditionalTask() { }

		public ConditionalTask(ICondition condition, IRenamingTask task)
		{
			this.Condition = condition;
			this.Action = task;
		}

		public ICondition Condition { get; set; }

		public IRenamingTask Action { get; set; }

		public void ApplyOn(File datei)
		{
			if (Condition.IsFulFilled())
				Action.ApplyOn(datei);
		}

		public IRenamingTask Self
		{
			get { return this; }
		}

		public string Description
		{
			get { return "Conditional Task"; }
		}

		public IRenamingTask GetNewInstance()
		{
			return new ConditionalTask(Condition.GetNewInstance(), Action.GetNewInstance());
		}

		public void ResetTask()
		{
			Condition = null;
			Action = null;
		}

		public string NameInTaskSelectionList
		{
			get { return "Conditional Task"; }
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	}
}
