using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.SortingTasks
{
  public class ExifDateSorting : AbstractTask, ISortingTask
  {
    public ExifDateSorting()
      : this(SortingOrder.Ascending)
    { }

    public ExifDateSorting(SortingOrder order)
    {
      Ordering = order;
      SelectedDateTimeSortingTag = ExifDateTimeSorting.DateTimeDigitized;
    }

    public ExifDateTimeSorting SelectedDateTimeSortingTag { get; set; }

    public override string NameInTaskSelectionList
    {
      get { return "EXIF Date Sorting"; }
    }

    public override string Description
    {
      get { return "EXIF Date Sorting"; }
    }

    public SortingOrder Ordering { get; set; }

    public ISortingTask GetNewInstance()
    {
      return new ExifDateSorting();
    }

    public int Compare(File x, File y)
    {
      if (x == null && y == null)
        return 0;
      else if (x != null && y == null)
        return 1;
      else if (x == null && y != null)
        return -1;
      else
      {
        string xDate = String.Empty;
        string yDate = String.Empty;

        switch (SelectedDateTimeSortingTag)
        {
          case ExifDateTimeSorting.DateTime:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTime];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTime];
            break;

          case ExifDateTimeSorting.DateTimeDigitized:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTimeDigitized];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTimeDigitized];

            break;
          case ExifDateTimeSorting.DateTimeOriginal:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTimeOriginal];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTimeOriginal];
            break;
          case ExifDateTimeSorting.GPSTimestamp:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.GPSTimestamp];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.GPSTimestamp];
            break;
        }

        return xDate.CompareTo(yDate);
      }
    }

    public enum ExifDateTimeSorting { DateTime, DateTimeDigitized, DateTimeOriginal, GPSTimestamp, }
  }
}
