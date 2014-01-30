using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.RenamingTasks.TaskLibrary
{
  public interface IRenamingTask
  {
    void ApplyOn(File datei);

    IRenamingTask Self { get; }

    string Description { get; }

    string ListName { get; }

    Bitmap ListIcon { get; }

    IRenamingTask GetNewInstance();

    void ResetTask();
  }
}
