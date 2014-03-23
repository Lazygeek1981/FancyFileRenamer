using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public interface IRenamingTask : ITask
  {
    void ApplyOn(File datei);

    IRenamingTask Self { get; }

    string Description { get; }

    string NameInTaskSelectionList { get; }

    IRenamingTask GetNewInstance();

    void ResetTask();
  }
}
