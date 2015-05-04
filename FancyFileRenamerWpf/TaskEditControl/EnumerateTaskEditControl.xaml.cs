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
  public partial class EnumerateTaskEditControl : Window, ITaskEditControl
  {
    private bool isLatched = false;

    public EnumerateTask Task { get; set; }

    public EnumerateTaskEditControl()
    {
      isLatched = true;
      InitializeComponent();
      isLatched = false;
    }

    public void UpdateTaskFromControl()
    {
      if (isLatched)
        return;

      Task.CustomPosition = textCustomPosition.Text.ToIntegerSafely(0);
      Task.StartAt = textStartWith.Text.ToIntegerSafely(0);
      Task.NumberFormat = textFormat.Text;
      Task.InsertAt = (EnumerateNumberPosition)comboInsertPosition.SelectedIndex;
    }

    public void SetTaskToControl(ITask task)
    {
      isLatched = true;

      Task = task.As<EnumerateTask>();

      textCustomPosition.Text = Task.CustomPosition.ToString();
      textStartWith.Text = Task.StartAt.ToString();
      textFormat.Text = Task.NumberFormat;
      comboInsertPosition.SelectedIndex = (int)Task.InsertAt;

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
