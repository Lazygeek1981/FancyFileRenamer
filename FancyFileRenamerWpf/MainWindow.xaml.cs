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

namespace FancyFileRenamerWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public ObservableCollection<IRenamingTask> AllAvailableTasks { get; set; }

    public ObservableCollection<IRenamingTask> CurrentTasks { get; set; }

    public MainWindow()
    {
      InitializeComponent();

      DataContext = this;

      loadAvailableTasks();
      CurrentTasks = new ObservableCollection<IRenamingTask>();
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
      CurrentTasks.Add((comboTasks.SelectedItem as IRenamingTask).GetNewInstance());
      comboTasks.SelectedIndex = 0;
    }

    private void btnStartRenaming_Click(object sender, RoutedEventArgs e)
    {

    }

    private void buttonLoadPath_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}
