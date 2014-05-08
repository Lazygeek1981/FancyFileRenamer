using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public class FilenameSorting : AbstractTask, ISortingTask
  {
    public FilenameSorting()
      : this(SortingOrder.Ascending)
    { }

    public FilenameSorting(SortingOrder order)
    {
      Ordering = order;
    }

    public SortingOrder Ordering { get; set; }

    public int Compare(File fileA, File fileB)
    {
      if (Ordering == SortingOrder.Ascending)
        return fileA.Filename.CompareTo(fileB.Filename);
      else
        return -fileA.Filename.CompareTo(fileB.Filename);
    }

    public override string NameInTaskSelectionList
    {
      get { return "Filename"; }
    }

    #region ISortingTask Members


    public ISortingTask GetNewInstance()
    {
      return new FilenameSorting();
    }

    #endregion

    public override string Description
    {
      get { return "Filename sorting"; }
    }
  }
}
