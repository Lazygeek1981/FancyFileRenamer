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
  public partial class InsertTaskEditControl : UserControl, ITaskEditControl
  {
    public InsertTaskEditControl()
    {
      InitializeComponent();
      
    }

    private InsertTask currentTask;

    public void UpdateTaskFromControl()
    {
      if (currentTask == null)
        currentTask = new InsertTask();

      currentTask.InsertValue = textInsertValue.Text;

      currentTask.Position = (int)numPosition.Value;
    }

    public void SetTaskToControl(ITask task)
    {
      currentTask = (InsertTask)task;

      numPosition.Value = currentTask.Position;
      textInsertValue.Text = currentTask.InsertValue;
    }

    public event TaskChangedEventHandler TaskChanged;

    private void textInsertValue_TextChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }
  }
}
