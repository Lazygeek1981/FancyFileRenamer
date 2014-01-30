﻿using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.RenamingTasks.TaskLibrary
{
  public class ChangeFileExtensionTask : IRenamingTask
  {
    public ChangeFileExtensionTask()
    {
      NewExtension = String.Empty;
    }

    public string NewExtension { get; set; }

    public void ApplyOn(File datei)
    {
      datei.newFilename = System.IO.Path.ChangeExtension(datei.newFilename, NewExtension);
    }

    public IRenamingTask Self
    {
      get { return this; }
    }

    public string Description
    {
      get { return String.Format("CHANGE FILE EXTENSION"); }
    }

    public string NameInTaskSelectionList
    {
      get { return "Change file extension"; }
    }

    public IRenamingTask GetNewInstance()
    {
      return new ChangeFileExtensionTask();
    }

    public void ResetTask()
    {
      //nothing todo here!
    }
  }
}
