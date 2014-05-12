using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public class ExifDateSorting : AbstractTask, ISortingTask
  {
    public override string NameInTaskSelectionList
    {
      get { return "EXIF Date"; }
    }

    public override string Description
    {
      get { return "EXIF Date sorting"; }
    }

    public SortingOrder Ordering { get; set; }

    public ISortingTask GetNewInstance()
    {
      return new ExifDateSorting();
    }

    public int Compare(File x, File y)
    {
      if (x != null && x.ExifPhotoCreationDate.HasValue && y != null && y.ExifPhotoCreationDate.HasValue)
        return x.ExifPhotoCreationDate.Value.CompareTo(y.ExifPhotoCreationDate.Value);
      else
        return 0;
    }
  }
}
