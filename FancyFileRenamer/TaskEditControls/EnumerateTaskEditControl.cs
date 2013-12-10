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
using System.Collections;

namespace FancyFileRenamer.TaskEditControls
{
  public partial class EnumerateTaskEditControl : UserControl, ITaskEditControl
  {
    private EnumerateTask currentTask = null;

    public EnumerateTaskEditControl()
    {
      InitializeComponent();

      fillComboBox();
    }

    private void fillComboBox()
    {
      comboInsertAt.Items.Clear();

      foreach (var item in Enum.GetValues(typeof(NumberPosition)))
      {
        comboInsertAt.Items.Add(item);
      }

      comboInsertAt.SelectedIndex = 0;
    }

    private NumberPosition getPosition()
    {
      return (NumberPosition)comboInsertAt.SelectedItem;
    }

    public void UpdateTaskFromControl()
    {
      if (currentTask == null)
        currentTask = new EnumerateTask();

      currentTask.StartAt = (int)numStartAt.Value;
      currentTask.NumberFormat = txtFormat.Text;

      currentTask.InsertAt = (NumberPosition)comboInsertAt.SelectedItem;
    }

    public void SetTaskToControl(ITask task)
    {
      currentTask = (EnumerateTask)task;

      txtFormat.Text = currentTask.NumberFormat;
      numStartAt.Value = currentTask.StartAt;
      comboInsertAt.SelectedItem = currentTask.InsertAt;      
    }

    public event TaskChangedEventHandler TaskChanged;

    private void numStartAt_ValueChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }

    private void txtFormat_TextChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }

    private void comboInsertAt_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }

    private void numCustomPosition_ValueChanged(object sender, EventArgs e)
    {
      UpdateTaskFromControl();

      if (TaskChanged != null)
        TaskChanged(this, currentTask);
    }
  }
}
