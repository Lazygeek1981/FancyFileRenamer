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
using FancyFileRenamer.TaskLibrary.SortingTasks;

namespace FancyFileRenamerWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public ObservableCollection<IRenamingTask> AllAvailableRenamingTasks { get; set; }

    public TrulyObservableCollection<IRenamingTask> CurrentRenamingTasks { get; set; }

    public ObservableCollection<ISortingTask> AllAvailableSortingTasks { get; set; }

    public TrulyObservableCollection<ISortingTask> CurrentSortingTasks { get; set; }

    public Project Project { get; set; }

    public MainWindow()
    {
      InitializeComponent();

      DataContext = this;
      Project = new FancyFileRenamer.TaskLibrary.Project();

      loadAvailableTasks();

      CurrentRenamingTasks = new TrulyObservableCollection<IRenamingTask>();
      CurrentSortingTasks = new TrulyObservableCollection<ISortingTask>();

#if DEBUG
      createDebugDummyData();
#endif

      listSourceScrollViewer = GetDescendantByType(listSource, typeof(ScrollViewer)) as ScrollViewer;
      listResultScrollViewer = GetDescendantByType(listResult, typeof(ScrollViewer)) as ScrollViewer;
    }

    private void createDebugDummyData()
    {
      for (int i = 0; i < 1000; i++)
      {
        Project.Files.Add(new FancyFileRenamer.TaskLibrary.File("example" + (1000 - i).ToString("0000") + ".avi"));
      }
    }

    private void loadAvailableTasks()
    {
      AllAvailableRenamingTasks = new ObservableCollection<IRenamingTask>();
      AllAvailableRenamingTasks.Add(null);
      AllAvailableRenamingTasks.Add(new ReplaceTask());
      AllAvailableRenamingTasks.Add(new EnumerateTask());
      AllAvailableRenamingTasks.Add(new ClearEntireFilenameTask());
      AllAvailableRenamingTasks.Add(new ChangeFileExtensionTask());
      AllAvailableRenamingTasks.Add(new InsertTask());

      AllAvailableSortingTasks = new ObservableCollection<ISortingTask>();
      AllAvailableSortingTasks.Add(null);
      AllAvailableSortingTasks.Add(new FilenameSorting());
      AllAvailableSortingTasks.Add(new SizeSorting());
      AllAvailableSortingTasks.Add(new CreationDateSorting());
      AllAvailableSortingTasks.Add(new ExifDateSorting());
    }

    private Visual GetDescendantByType(Visual element, Type type)
    {
      if (element == null) return null;
      if (element.GetType() == type) return element;
      Visual foundElement = null;
      if (element is FrameworkElement)
      {
        (element as FrameworkElement).ApplyTemplate();
      }
      for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
      {
        Visual visual = VisualTreeHelper.GetChild(element, i) as Visual;
        foundElement = GetDescendantByType(visual, type);
        if (foundElement != null)
          break;
      }
      return foundElement;
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
      CurrentRenamingTasks.Add(task);
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
      if (Project != null && Project.Files.All(x => x.IsValid))
      {
        Project.ApplyTasks();
        Project.DoRenaming();
      }
    }

    private void renamingTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      editRenamingTask();
    }

    private void buttonRenamingTaskEdit_Click(object sender, RoutedEventArgs e)
    {
      editRenamingTask();
    }


    private void editRenamingTask()
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
            refreshFileListsWithoutSorting();
            renamingTasks.UpdateLayout();
          }
        }
      }
    }

    private void buttonRenamingTaskRemove_Click(object sender, RoutedEventArgs e)
    {
      IRenamingTask task = renamingTasks.SelectedItem.As<IRenamingTask>();

      CurrentRenamingTasks.Remove(task);
      Project.RenamingTasks.Remove(task);

      refreshFileListsWithoutSorting();
    }

    private void buttonSortingTaskEdit_Click(object sender, RoutedEventArgs e)
    {
      editSortingTask();
    }

    private void editSortingTask()
    {
      if (sortingTasks.SelectedItems != null && sortingTasks.SelectedItems.Count > 0)
      {
        ITask selectedTask = sortingTasks.SelectedItems[0].As<ITask>();

        ITaskEditControl editControl = TaskEditControlFactory.GetControlForTask(selectedTask);

        if (editControl != null)
        {
          bool? result = editControl.As<Window>().ShowDialog();

          if (result.HasValue && result.Value)
          {
            refreshFileListsWithSorting();
            sortingTasks.UpdateLayout();
          }
        }
      }
    }

    private void buttonSortingTaskAdd_Click(object sender, RoutedEventArgs e)
    {
      ISortingTask task = (comboSortingTasks.SelectedItem as ISortingTask).GetNewInstance();

      task.PropertyChanged += task_PropertyChanged;
      CurrentSortingTasks.Add(task);
      Project.SortingTasks.Add(task);

      comboSortingTasks.SelectedIndex = 0;

      refreshFileListsWithSorting();
    }

    private void sortingTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      buttonSortingTaskDown.IsEnabled = sortingTasks.SelectedIndex < sortingTasks.Items.Count - 1;
      buttonSortingTaskUp.IsEnabled = sortingTasks.SelectedIndex > 0;
      buttonSortingTaskRemove.IsEnabled = sortingTasks.SelectedItem != null;
      buttonSortingTaskEdit.IsEnabled = sortingTasks.SelectedItem != null;
    }

    private void buttonSortingTaskRemove_Click(object sender, RoutedEventArgs e)
    {
      ISortingTask task = sortingTasks.SelectedItem.As<ISortingTask>();

      CurrentSortingTasks.Remove(task);
      Project.SortingTasks.Remove(task);


      refreshFileListsWithSorting();
    }

    private void refreshFileListsWithSorting()
    {
      Project.SortFiles();

      refreshFileListsWithoutSorting();
    }

    private void refreshFileListsWithoutSorting()
    {
      Project.ApplyTasks();

      listSource.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateTarget();
      listResult.GetBindingExpression(ListBox.ItemsSourceProperty).UpdateTarget();
    }

    private bool sourceScrolling = false;
    private bool resultScrolling = false;

    private ScrollViewer listSourceScrollViewer = null;
    private ScrollViewer listResultScrollViewer = null;

    private void listSource_ScrollChanged(object sender, ScrollChangedEventArgs e)
    {
      if (resultScrolling)
        return;

      sourceScrolling = true;

      listResultScrollViewer.ScrollToVerticalOffset(listSourceScrollViewer.VerticalOffset);

      sourceScrolling = false;
    }



    private void listResult_ScrollChanged(object sender, ScrollChangedEventArgs e)
    {
      if (sourceScrolling)
        return;

      resultScrolling = true;

      listSourceScrollViewer.ScrollToVerticalOffset(listResultScrollViewer.VerticalOffset);

      resultScrolling = false;
    }
  }
}
