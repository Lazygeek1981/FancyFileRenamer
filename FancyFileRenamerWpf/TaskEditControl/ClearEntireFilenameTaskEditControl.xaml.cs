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
using FancyFileRenamer.TaskLibrary.RenamingTasks;

namespace FancyFileRenamerWpf.TaskEditControl
{
  /// <summary>
  /// Interaction logic for EnumerateTaskEditControl.xaml
  /// </summary>
  public partial class ClearEntireFilenameTaskEditControl : Window, ITaskEditControl
  {
    private bool isLatched = false;

    public ClearEntireFilenameTask Task { get; set; }

    public ClearEntireFilenameTaskEditControl()
    {
      isLatched = true;
      InitializeComponent();
      isLatched = false;
    }

    public void UpdateTaskFromControl()
    {
      if (isLatched)
        return;

      Task.ClearFileExtension = checkClearExtension.IsChecked.Value;
    }

    public void SetTaskToControl(ITask task)
    {
      isLatched = true;

      Task = task.As<ClearEntireFilenameTask>();

      checkClearExtension.IsChecked = Task.ClearFileExtension;

      isLatched = false;
    }

    private void buttonOK_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
    }

    private void checkChanged(object sender, RoutedEventArgs e)
    {
      UpdateTaskFromControl();
    }

    
  }
}
