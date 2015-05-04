using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.Enums;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
	public class TaskPositionPart
	{
		public TaskPositionPart()
		{
			Position = Enums.Position.Beginning;
			CustomPosition = 0;
		}

		public Position Position { get; set; }

		public int CustomPosition { get; set; }
	}
}
