using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer
{
  public class TaskListEntry
  {
    public TaskListEntry(ITask task, ITaskEditControl editControl)
    {
      Task = task;
      EditControl = editControl;
    }

    public ITask Task { get; set; }

    public ITaskEditControl EditControl { get; set; }

    public string Description
    {
      get
      {
        if (Task != null)
          return Task.Description;
        else
          return String.Empty;
      }
    }

    public TaskListEntry Self { get { return this; } }
  }
}
