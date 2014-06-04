using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.SortingTasks;

namespace FancyFileRenamerWpf.TaskEditControl
{
  /// <summary>
  /// Interaction logic for ExifSortingTaskEditControl.xaml
  /// </summary>
  public partial class ExifSortingTaskEditControl : Window, ITaskEditControl
  {
    public ExifDateSorting Task { get; set; }

    public ExifSortingTaskEditControl()
    {
      InitializeComponent();
    }

    

    public void UpdateTaskFromControl()
    {
      Task.Ordering = radioAscending.IsChecked.GetValueOrDefault(true) ? SortingOrder.Ascending : SortingOrder.Descending;

      switch (comboSortingDate.SelectedIndex)
      { 
        default:
        case 0:
          Task.SelectedDateTimeSortingTag = ExifDateSorting.ExifDateTimeSorting.DateTime;
          break;
        case 1:
          Task.SelectedDateTimeSortingTag = ExifDateSorting.ExifDateTimeSorting.DateTimeDigitized;
          break;
        case 2:
          Task.SelectedDateTimeSortingTag = ExifDateSorting.ExifDateTimeSorting.DateTimeOriginal;
          break;
        case 3:
          Task.SelectedDateTimeSortingTag = ExifDateSorting.ExifDateTimeSorting.GPSTimestamp;
          break;
      }
    }

    public void SetTaskToControl(ITask task)
    {
      Task = task.As<ExifDateSorting>();

      if (Task.Ordering == SortingOrder.Ascending)
        radioAscending.IsChecked = true;
      else
        radioDescending.IsChecked = true;

      switch (Task.SelectedDateTimeSortingTag)
      { 
        case ExifDateSorting.ExifDateTimeSorting.DateTime:
          comboSortingDate.SelectedIndex = 0;
          break;
        case ExifDateSorting.ExifDateTimeSorting.DateTimeDigitized:
          comboSortingDate.SelectedIndex = 1;
          break;
        case ExifDateSorting.ExifDateTimeSorting.DateTimeOriginal:
          comboSortingDate.SelectedIndex = 2;
          break;
        case ExifDateSorting.ExifDateTimeSorting.GPSTimestamp:
          comboSortingDate.SelectedIndex = 3;
          break;
      }
    }

    private void buttonOK_Click(object sender, RoutedEventArgs e)
    {
      UpdateTaskFromControl();
      DialogResult = true;
    }
  }
}
