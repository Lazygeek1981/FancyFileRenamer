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
  public partial class ClearEntireFilenameTaskEditControl : UserControl, ITaskEditControl
  {
    private ClearEntireFilenameTask currentTask = null;

    public ClearEntireFilenameTaskEditControl()
    {
      InitializeComponent();

      initializeEvents();
    }

    private void initializeEvents()
    {
      checkClearExtensions.CheckedChanged += checkClearExtensions_CheckedChanged;
    }

    void checkClearExtensions_CheckedChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }

    public void UpdateTaskFromControl()
    {
      if (currentTask == null)
        currentTask = new ClearEntireFilenameTask();

      currentTask.ClearFileExtension = checkClearExtensions.Checked;
    }

    public void SetTaskToControl(ITask task)
    {
      currentTask = (ClearEntireFilenameTask)task;

      checkClearExtensions.Checked = this.currentTask.ClearFileExtension;
    }

    public event TaskChangedEventHandler TaskChanged;
  }
}
