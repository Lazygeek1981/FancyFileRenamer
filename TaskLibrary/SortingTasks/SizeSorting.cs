using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public class SizeSorting : AbstractTask, ISortingTask
  {
    public SizeSorting()
    {
      Ordering = SortingOrder.Ascending;
    }

    public SortingOrder Ordering { get; set; }

    public int Compare(File fileA, File fileB)
    {
      if (Ordering == SortingOrder.Ascending)
        return fileA.Size.CompareTo(fileB.Size);
      else
        return -fileA.Size.CompareTo(fileB.Size);
    }
  }
}
