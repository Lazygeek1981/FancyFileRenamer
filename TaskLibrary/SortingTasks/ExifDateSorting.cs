using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.Enums;

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
      SelectedDateTimeSortingTag = ExifDateTimeProperty.DateTimeDigitized;
    }

    public ExifDateTimeProperty SelectedDateTimeSortingTag { get; set; }

    public override string NameInTaskSelectionList
    {
      get { return "EXIF Date Sorting"; }
    }

    public override string Description
    {
      get { return "EXIF Date Sorting"; }
    }

    public SortingOrder Ordering { get; set; }

    public override ITask GetNewInstance()
    {
      return new ExifDateSorting();
    }

    public int Compare(FancyFile x, FancyFile y)
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
          case ExifDateTimeProperty.DateTime:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTime];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTime];
            break;

          case ExifDateTimeProperty.DateTimeDigitized:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTimeDigitized];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTimeDigitized];

            break;
          case ExifDateTimeProperty.DateTimeOriginal:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.DateTimeOriginal];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.DateTimeOriginal];
            break;
          case ExifDateTimeProperty.GPSTimestamp:
            if (x.HasExifTags)
              xDate = x.ExifTagValues[ExifLib.ExifTags.GPSTimestamp];
            if (y.HasExifTags)
              yDate = y.ExifTagValues[ExifLib.ExifTags.GPSTimestamp];
            break;
        }

        return xDate.CompareTo(yDate);
      }
    }
  }
}
