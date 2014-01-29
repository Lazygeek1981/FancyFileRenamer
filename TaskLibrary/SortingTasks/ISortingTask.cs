using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public interface IOrderingTask
  {
    Order Ordering { get; set; }

    int Compare(File fileA, File fileB);
  }
}
