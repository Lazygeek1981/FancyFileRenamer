using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class ReplaceTask : AbstractTask, IRenamingTask
  {
    private string searchFor = String.Empty;
    private string replaceWith = String.Empty;

    public ReplaceTask()
    { 
     //nothing to do here
    }

    public string SearchFor { get { return searchFor; } set { searchFor = value; changed(); } }

    public string ReplaceWith { get { return replaceWith; } set { replaceWith = value; changed(); } }

    public void ApplyOn(File datei)
    {
      if (SearchFor.IsFilled())
        datei.NewFilename = datei.NewFilename.Replace(SearchFor, ReplaceWith);
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
      SearchFor = String.Empty;
      ReplaceWith = String.Empty;
    }
  }
}
