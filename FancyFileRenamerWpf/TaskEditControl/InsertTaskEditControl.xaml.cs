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
  public partial class InsertTaskEditControl : Window, ITaskEditControl
  {
    private bool isLatched = false;

    public InsertTask Task { get; set; }

    public InsertTaskEditControl()
    {
      isLatched = true;
      InitializeComponent();
      isLatched = false;
    }

    public void UpdateTaskFromControl()
    {
      if (isLatched)
        return;

      Task.Position = textAtPosition.Text.ToIntegerSafely(0);
      Task.InsertValue = textInsert.Text;

    }

    public void SetTaskToControl(ITask task)
    {
      isLatched = true;

      Task = task.As<InsertTask>();

      textInsert.Text = Task.InsertValue;
      textAtPosition.Text = Task.Position.ToString();

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

    private void comboInsertPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      UpdateTaskFromControl();
    }

    
  }
}
