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

    public int Compare(FancyFile fileA, FancyFile fileB)
    {
      int compareResult = 0;

      if (fileA.Size.HasValue && fileB.Size.HasValue)
      {
        compareResult = fileA.Size.Value.CompareTo(fileB.Size.Value);
      }
      else if (fileA.Size.HasValue && !fileB.Size.HasValue)
      {
        compareResult = 1;
      }
      else
        compareResult = -1;
      

      if (Ordering == SortingOrder.Ascending)
        return compareResult;
      else
        return -compareResult;

    }

    public override string NameInTaskSelectionList
    {
      get { return "Size"; }
    }

    public override ITask GetNewInstance()
    {
      return new SizeSorting();
    }

    public override string Description
    {
      get { return "Filesize sorting"; }
    }
  }
}
