using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FancyFileRenamer.Tasks;

namespace FancyFileRenamer.TaskEditControls
{
  public partial class ReplaceTaskEditControl : UserControl, ITaskEditControl
  {
    private ReplaceTask currentTask;

    public ReplaceTaskEditControl()
    {
      InitializeComponent();
      initializeEvents();
    }

    private void initializeEvents()
    {
      txtReplaceWith.TextChanged += textChanged;
      txtSearchFor.TextChanged += textChanged;
    }

    private void textChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }

    public void UpdateTaskFromControl()
    {
      if (currentTask == null)
        currentTask = new ReplaceTask();

      currentTask.SearchFor = txtSearchFor.Text;
      currentTask.ReplaceWith = txtReplaceWith.Text;
    }

    public void SetTaskToControl(ITask task)
    {
      currentTask = (ReplaceTask)task;

      txtReplaceWith.Text = currentTask.ReplaceWith;
      txtSearchFor.Text = currentTask.SearchFor;
    }

    public event TaskChangedEventHandler TaskChanged;
  }
}
