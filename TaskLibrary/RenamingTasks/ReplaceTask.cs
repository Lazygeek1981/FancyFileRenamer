using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class ReplaceTask : IRenamingTask
  {
    public ReplaceTask()
    {
      SearchFor = String.Empty;
      ReplaceWith = String.Empty;
    }

    public string SearchFor { get; set; }

    public string ReplaceWith { get; set; }

    public void ApplyOn(File datei)
    {
      if (SearchFor.IsFilled())
        datei.newFilename = datei.newFilename.Replace(SearchFor, ReplaceWith);
    }

    public string Description
    {
      get { return String.Format("REPLACE: {0} -> {1}", (SearchFor != String.Empty ? SearchFor : "<empty>"), (ReplaceWith != String.Empty ? ReplaceWith : "<empty>")); }
    }

    public string NameInTaskSelectionList
    {
      get { return "Replace values"; }
    }

    public IRenamingTask Self
    {
      get { return this; }
    }

    public IRenamingTask GetNewInstance()
    {
      return new ReplaceTask();
    }

    public void ResetTask()
    {
      //nothing to do here
    }
  }
}
