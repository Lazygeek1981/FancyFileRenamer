using FancyFileRenamer.TaskLibrary.RenamingTasks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FancyFileRenamer.TaskLibrary;
using System.IO;

namespace FancyFileRenamerWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public ObservableCollection<IRenamingTask> AllAvailableTasks { get; set; }

    public TrulyObservableCollection<IRenamingTask> CurrentTasks { get; set; }

    public Project Project { get; set; }

    public MainWindow()
    {
      InitializeComponent();

      DataContext = this;
      Project = new FancyFileRenamer.TaskLibrary.Project();

      loadAvailableTasks();

      CurrentTasks = new TrulyObservableCollection<IRenamingTask>();

#if DEBUG
      for (int i = 0; i < 1000; i++)
      {
        Project.Files.Add(new FancyFileRenamer.TaskLibrary.File("example" + i.ToString("0000")+".avi"));
      }

#endif
    }

    private void loadAvailableTasks()
    {
      AllAvailableTasks = new ObservableCollection<IRenamingTask>();
      AllAvailableTasks.Add(null);
      AllAvailableTasks.Add(new ReplaceTask());
      AllAvailableTasks.Add(new EnumerateTask());
      AllAvailableTasks.Add(new ClearEntireFilenameTask());
      AllAvailableTasks.Add(new ChangeFileExtensionTask());
      AllAvailableTasks.Add(new InsertTask());
    }

    private void renamingTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      buttonRenamingTaskDown.IsEnabled = renamingTasks.SelectedIndex < renamingTasks.Items.Count - 1;
      buttonRenamingTaskUp.IsEnabled = renamingTasks.SelectedIndex > 0;
      buttonRenamingTaskRemove.IsEnabled = renamingTasks.SelectedItem != null;
      buttonRenamingTaskEdit.IsEnabled = renamingTasks.SelectedItem != null;
    }

    private void buttonRenamingTaskAdd_Click(object sender, RoutedEventArgs e)
    {
      IRenamingTask task = (comboTasks.SelectedItem as IRenamingTask).GetNewInstance();

      task.PropertyChanged += task_PropertyChanged;
      CurrentTasks.Add(task);
      Project.RenamingTasks.Add(task);

      comboTasks.SelectedIndex = 0;

      Project.ApplyTasks();
    }

    void task_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if (checkRealTimeUpdate.IsChecked.Value)
        Project.ApplyTasks();
    }

    private void buttonLoadPath_Click(object sender, RoutedEventArgs e)
    {
      if (txtPath.Text.IsFilled() && Directory.Exists(txtPath.Text))
      {
        Project.SourcePath = new DirectoryInfo(txtPath.Text);
      }
      else
      {
        MessageBox.Show("Can't find or open directory", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }
    }

    private void buttonStartRenaming_Click(object sender, RoutedEventArgs e)
    {

    }

    private void renamingTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      editTask();
    }

    private void buttonRenamingTaskEdit_Click(object sender, RoutedEventArgs e)
    {
      editTask();
    }


    private void editTask()
    {
      if (renamingTasks.SelectedItems != null && renamingTasks.SelectedItems.Count > 0)
      {
        ITask selectedTask = renamingTasks.SelectedItems[0].As<ITask>();

        ITaskEditControl editControl = TaskEditControlFactory.GetControlForTask(selectedTask);

        if (editControl != null)
        {
          bool? result = editControl.As<Window>().ShowDialog();

          if (result.HasValue && result.Value)
          {
            Project.ApplyTasks();
            renamingTasks.UpdateLayout();
          }
        }

      }
    }
  }
}
