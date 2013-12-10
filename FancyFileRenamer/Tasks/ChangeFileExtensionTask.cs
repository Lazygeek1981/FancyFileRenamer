using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.Tasks
{
  public class ChangeFileExtensionTask : ITask
  {
    public ChangeFileExtensionTask()
    {
      NewExtension = String.Empty;
    }

    public string NewExtension { get; set; }

    public void ApplyOn(File datei)
    {
      datei.newFilename = Path.ChangeExtension(datei.newFilename, NewExtension);
    }

    public ITask Self
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

    public ITask GetNewInstance()
    {
      return new ChangeFileExtensionTask();
    }

    public void ResetTask()
    {
      //nothing todo here!
    }
  }
}
