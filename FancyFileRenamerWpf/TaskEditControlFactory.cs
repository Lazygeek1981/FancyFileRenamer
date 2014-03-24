using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using FancyFileRenamerWpf.TaskEditControl;

namespace FancyFileRenamerWpf
{
  public static class TaskEditControlFactory
  {
    public static ITaskEditControl GetControlForTask(ITask task)
    {
      ITaskEditControl editControl = null;

      if (task is ReplaceTask)
        editControl = new ReplaceTaskEditControl();
      //else if (task is EnumerateTask)
      //  return new EnumerateTaskEditControl();
      //else if (task is InsertTask)
      //  return new InsertTaskEditControl();
      //else if (task is ClearEntireFilenameTask)
      //  return new ClearEntireFilenameTaskEditControl();
      else
        throw new InvalidOperationException("Can't find edit control for task");

      editControl.SetTaskToControl(task);

      return editControl;
    }
  }
}
