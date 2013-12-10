using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.Tasks
{
  public class InsertTask : ITask
  {
    public InsertTask()
    {
      InsertValue = String.Empty;
      Position = 0;
    }

    public string InsertValue { get; set; }

    public int Position { get; set; }

    public void ApplyOn(File datei)
    {
      if (InsertValue.IsFilled())
        datei.newFilename = datei.newFilename.Insert(Position, InsertValue);
    }

    public ITask Self
    {
      get { return this; }
    }

    public string Description
    {
      get { return "Insert text"; }
    }

    public string NameInTaskSelectionList
    {
      get { return "Insert text"; }
    }

    public ITask GetNewInstance()
    {
      return new InsertTask();
    }


    public void ResetTask()
    {
      //nothing todo here!
    }
  }
}
