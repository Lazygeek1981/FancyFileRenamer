using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class ClearEntireFilenameTask : AbstractTask, IRenamingTask
  {
    private bool clearFileExtension = false;

    public ClearEntireFilenameTask()
    {
      //nothing to do here
    }

    public bool ClearFileExtension { get { return clearFileExtension; } set { clearFileExtension = value; propertyChanged("ClearFileExtension"); } }

    public void ApplyOn(File datei)
    {
      if (ClearFileExtension)
        datei.NewFilename = String.Empty;
      else
        datei.NewFilename = String.Empty + Path.GetExtension(datei.NewFilename);
    }

    public IRenamingTask Self
    {
      get { return this; }
    }

    public string Description
    {
      get { return clearFileExtension ? "Clear entire filename" : " Clear filename w/o extension"; }
    }

    public string NameInTaskSelectionList
    {
      get { return "Clear entire filename"; }
    }

    public IRenamingTask GetNewInstance()
    {
      return new ClearEntireFilenameTask();
    }

    public void ResetTask()
    {
      //nothing to do here
    }
  }
}
