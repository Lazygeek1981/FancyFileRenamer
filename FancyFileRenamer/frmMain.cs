using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FancyFileRenamer.Tasks;

namespace FancyFileRenamer
{
  public partial class frmMain : Form
  {
    private bool isLoading = false;

    private BunchOfFiles bunch = new BunchOfFiles();

    public frmMain()
    {
      InitializeComponent();

      initializeListBoxes();

      loadTasks();
    }

    private void initializeListBoxes()
    {
      listBxSource.DisplayMember = "Filename";
      listBxSource.ValueMember = "Self";

      listBoxTasksToApply.DisplayMember = "Description";
      listBoxTasksToApply.ValueMember = "Self";

      listBoxPreview.DisplayMember = "newFilename";
      listBoxPreview.ValueMember = "Self";
    }

    private void loadTasks()
    {
      comboTasks.Items.Clear();
      comboTasks.Items.Add(new ReplaceTask());
      comboTasks.Items.Add(new EnumerateTask());
      comboTasks.Items.Add(new InsertTask());
      comboTasks.Items.Add(new ClearEntireFilenameTask());

      comboTasks.ValueMember = "Self";
      comboTasks.DisplayMember = "NameInTaskSelectionList";
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
      isLoading = true;
      listBxSource.Items.Clear();
      try
      {
        foreach (string filePath in Directory.GetFiles(folderChooseBox.Text, txtPattern.Text))
        {
          listBxSource.Items.Add(new File(filePath));
          listBxSource.SetSelected(listBxSource.Items.Count - 1, true);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }

      sourceListToBunchOfFiles();

      processTasks();

      isLoading = false;
    }

    private void sourceListToBunchOfFiles()
    {
      bunch = new BunchOfFiles();

      foreach (var item in listBxSource.SelectedItems)
      {
        if (item is File)
          bunch.Files.Add(item as File);
      }
    }

    private void comboTasks_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboTasks.SelectedItem is ITask)      
        btnAddTask.Enabled = true;      
      else
        btnAddTask.Enabled = false;
    }

    private void btnAddTask_Click(object sender, EventArgs e)
    {
      if (isValidTaskInComboBoxSelected())
      {
        ITask task = getNewInstanceOfSelectedTask();
        
        ITaskEditControl editControl = TaskEditControlFactory.GetControlForTask(task);

        editControl.TaskChanged += frmMain_TaskChanged;

        TaskListEntry entry = new TaskListEntry(task, editControl);

        listBoxTasksToApply.Items.Add(entry);
        
        processTasks();
      }
    }

    private bool isValidTaskInComboBoxSelected()
    {
      return comboTasks.SelectedItem != null && comboTasks.SelectedItem is ITask;
    }

    private ITask getNewInstanceOfSelectedTask()
    {
      return (comboTasks.SelectedItem as ITask).GetNewInstance();
    }

    protected void processTasks()
    {
      listBoxPreview.Items.Clear();

      List<ITask> tasks = getTasks();

      tasks.ForEach(x => x.ResetTask());

      bunch.ApplyTasks(tasks);

      bunchOfFilesToPreviewList();
    }

    private void bunchOfFilesToPreviewList()
    {
      bunch.Files.ForEach(file => listBoxPreview.Items.Add(file));
    }

    private List<ITask> getTasks()
    {
      List<ITask> tasks = new List<ITask>();

      foreach (var item in listBoxTasksToApply.Items)
      {
        if (item is TaskListEntry)
          tasks.Add((item as TaskListEntry).Task);
      }

      return tasks;
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      bunch.DoRename();
      btnLoad_Click(null, null);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (isValidTaskSelected())
      {
        listBoxTasksToApply.Items.Remove(listBoxTasksToApply.SelectedItem);
        panel1.Controls.Clear();
        processTasks();
      }
    }

    private bool isValidTaskSelected()
    {
      return (listBoxTasksToApply.SelectedItem != null && listBoxTasksToApply.SelectedItem is TaskListEntry);
    }

    private void listBxSource_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (isLoading)
        return;

      sourceListToBunchOfFiles();

      processTasks();
    }

    private void listBoxTasksToApply_SelectedIndexChanged(object sender, EventArgs e)
    {
      listBoxPreview.SelectedItem = listBoxPreview.SelectedItem;

      if (isValidTaskSelected())
      {
        panel1.Controls.Clear();

        TaskListEntry entry = (listBoxTasksToApply.SelectedItem as TaskListEntry);

        panel1.Controls.Add((UserControl)entry.EditControl);

        entry.EditControl.SetTaskToControl(entry.Task);
      }
    }

    void frmMain_TaskChanged(ITaskEditControl sender, ITask changedTask)
    {
      processTasks();
    }
  }
}
