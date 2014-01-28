using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FancyFileRenamer
{
  public partial class frmTaskEdit : Form
  {
    private ITaskEditControl taskEditControl = null;

    public frmTaskEdit()
    {
      InitializeComponent();
    }

    public void SetTaskEditControlAndTask(ITaskEditControl control, ITask task)
    {
      this.taskEditControl = control;
      splitContainer1.Panel1.Controls.Clear();
      splitContainer1.Panel1.Controls.Add(taskEditControl as Control);

      taskEditControl.SetTaskToControl(task);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      taskEditControl.UpdateTaskFromControl();
      DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Hide();
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
      DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Hide();
    }

  }
}
