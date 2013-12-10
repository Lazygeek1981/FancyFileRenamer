using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.Tasks
{
  public class ClearEntireFilenameTask : ITask
  {
    public ClearEntireFilenameTask()
    {
      ClearFileExtension = false;    
    }

    public bool ClearFileExtension { get; set; }

    public void ApplyOn(File datei)
    {
      if (ClearFileExtension)
        datei.newFilename = String.Empty;
      else
        datei.newFilename = String.Empty + Path.GetExtension(datei.newFilename);
    }

    public ITask Self
    {
      get { return this; }
    }

    public string Description
    {
      get { return "Clear filename"; }
    }

    public string NameInTaskSelectionList
    {
      get { return "Clear entire filename"; }
    }

    public ITask GetNewInstance()
    {
      return new ClearEntireFilenameTask();
    }

    public void ResetTask()
    {
      //nothing to do here
    }
  }
}
