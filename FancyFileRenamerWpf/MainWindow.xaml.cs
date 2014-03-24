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

    public ObservableCollection<IRenamingTask> CurrentTasks { get; set; }

    public Project Project { get; set; }

    public MainWindow()
    {
      InitializeComponent();

      DataContext = this;
      Project = new FancyFileRenamer.TaskLibrary.Project();

      loadAvailableTasks();

      CurrentTasks = new ObservableCollection<IRenamingTask>();

      Project.Files.Add(new FancyFileRenamer.TaskLibrary.File("asd"));
      Project.Files.Add(new FancyFileRenamer.TaskLibrary.File("asd123"));
      Project.Files.Add(new FancyFileRenamer.TaskLibrary.File("asd456"));
    }

    private void loadAvailableTasks()
    {
      AllAvailableTasks = new ObservableCollection<IRenamingTask>();
      AllAvailableTasks.Add(null);
      AllAvailableTasks.Add(new ReplaceTask());
      AllAvailableTasks.Add(new ChangeFileExtensionTask());
    }

    private void renamingTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      buttonRenamingTaskDown.IsEnabled = renamingTasks.SelectedIndex < renamingTasks.Items.Count - 1;
      buttonRenamingTaskUp.IsEnabled = renamingTasks.SelectedIndex > 0;
      buttonRenamingTaskRemove.IsEnabled = renamingTasks.SelectedItem != null;
    }

    private void buttonRenamingTaskAdd_Click(object sender, RoutedEventArgs e)
    {
      IRenamingTask task = (comboTasks.SelectedItem as IRenamingTask).GetNewInstance();

      task.Changed += taskChanged;

      CurrentTasks.Add(task);
      Project.RenamingTasks.Add(task);

      comboTasks.SelectedIndex = 0;
    }

    void taskChanged(ITask sender, EventArgs e)
    {
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
      if (renamingTasks.SelectedItems != null && renamingTasks.SelectedItems.Count > 0)
      {
        ITask selectedTask = renamingTasks.SelectedItems[0].As<ITask>();

        ITaskEditControl editControl = TaskEditControlFactory.GetControlForTask(selectedTask);

        if (editControl != null)
        {
          bool? result = editControl.As<Window>().ShowDialog();

          if (result.HasValue && result.Value)
            Project.ApplyTasks();
        }

      }
    }
  }
}
