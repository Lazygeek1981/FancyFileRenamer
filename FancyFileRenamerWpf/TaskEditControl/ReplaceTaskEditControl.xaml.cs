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
    public static RoutedCommand OkCommand = new RoutedCommand();
    public static RoutedCommand CancelCommand = new RoutedCommand();

    public ReplaceTask Task { get; set; }

    public event TaskChangedEventHandler TaskChanged;

    private Timer timer = new Timer(2000d);

    public ReplaceTaskEditControl()
    {
      InitializeComponent();

      OkCommand.InputGestures.Add(new KeyGesture(Key.Enter));
      CancelCommand.InputGestures.Add(new KeyGesture(Key.Escape));

      timer.Elapsed += timer_Elapsed;
    }

    void timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      string searchFor = txtSearchFor.Dispatcher.Invoke(new Func<string>(() => txtSearchFor.Text));
      string replaceWith = txtReplaceWith.Dispatcher.Invoke(new Func<string>(() => txtReplaceWith.Text));

      if (Task.SearchFor != searchFor || Task.ReplaceWith != replaceWith)
        UpdateTaskFromControl();
    }

    public void UpdateTaskFromControl()
    {
      string searchFor = txtSearchFor.Dispatcher.Invoke(new Func<string>(() => txtSearchFor.Text));
      string replaceWith = txtReplaceWith.Dispatcher.Invoke(new Func<string>(() => txtReplaceWith.Text));

      Task.SearchFor = searchFor;
      Task.ReplaceWith = replaceWith;
    }

    public void SetTaskToControl(ITask task)
    {
      Task = task.As<ReplaceTask>();
    }


    private void buttonOK_Click(object sender, RoutedEventArgs e)
    {
      OkCommandExecuted(sender, null);
    }

    private void buttonCancel_Click(object sender, RoutedEventArgs e)
    {
      CancelCommandExecuted(sender, null);
    }

    private void OkCommandExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      DialogResult = true;
    }

    private void CancelCommandExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      DialogResult = false;      
    }

    private void textChanged(object sender, TextChangedEventArgs e)
    {
      timer.Stop();
      timer.Start();
    }
  }
}
