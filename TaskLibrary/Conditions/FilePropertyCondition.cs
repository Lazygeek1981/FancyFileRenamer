using FancyFileRenamer.TaskLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.Conditions
{
	public class FilePropertyCondition
	{
		public BooleanRelation BooleanRealtion { get; set; }

		public FileProperty FileProperty { get; set; }

		public string Value { get; set; }
	}
}
