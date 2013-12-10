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
  public partial class ChangeFileExtensionTaskEditControl : UserControl, ITaskEditControl
  {
    private ChangeFileExtensionTask currentTask = null;

    public ChangeFileExtensionTaskEditControl()
    {
      InitializeComponent();
    }

    public void UpdateTaskFromControl()
    {
      if (currentTask == null)
        currentTask = new ChangeFileExtensionTask();

      currentTask.NewExtension = txtNewFileExtension.Text;
    }

    public void SetTaskToControl(ITask task)
    {
      this.currentTask = (ChangeFileExtensionTask)task;

      txtNewFileExtension.Text = this.currentTask.NewExtension;
    }

    public event TaskChangedEventHandler TaskChanged;

    private void txtNewFileExtension_TextChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }
  }
}
