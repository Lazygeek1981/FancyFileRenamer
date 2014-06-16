using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public class CreationDateSorting : AbstractTask, ISortingTask
  {
    public CreationDateSorting()
    {
      Ordering = SortingOrder.Ascending;
    }
    
    public SortingOrder Ordering { get; set; }

    public int Compare(File fileA, File fileB)
    {
      if (Ordering == SortingOrder.Ascending)
        return fileA.CreationDate.CompareTo(fileB.CreationDate);
      else
        return -fileA.CreationDate.CompareTo(fileB.CreationDate);
    }

    public override string NameInTaskSelectionList
    {
      get { return "Creation Date"; }
    }

    #region ISortingTask Members


    public ISortingTask GetNewInstance()
    {
      return new CreationDateSorting();

    }

    #endregion

    public override string Description
    {
      get { return "Creation Date Sorting, " + (Ordering == SortingOrder.Ascending ? "ascending": "descending"); }
    }
  }
}
