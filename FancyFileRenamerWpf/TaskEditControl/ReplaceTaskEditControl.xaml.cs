using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
  /// Interaction logic for ReplaceTaskEditControl.xaml
  /// </summary>
  public partial class ReplaceTaskEditControl : Window, ITaskEditControl
  {
    private bool isLatched = false;

    public ReplaceTask Task { get; set; }

    public ReplaceTaskEditControl()
    {
      isLatched = true;

      InitializeComponent();

      isLatched = false;
    }

    public void UpdateTaskFromControl()
    {
      if (isLatched)
        return;

      Task.SearchFor = txtSearchFor.Text;
      Task.ReplaceWith = txtReplaceWith.Text;
    }

    public void SetTaskToControl(ITask task)
    {
      isLatched = true;

      Task = task.As<ReplaceTask>();

      txtReplaceWith.Text = Task.ReplaceWith;
      txtSearchFor.Text = Task.SearchFor;

      isLatched = false;
    }

    private void buttonOK_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
    }

    private void textChanged(object sender, TextChangedEventArgs e)
    {
      UpdateTaskFromControl();
    }
  }
}
