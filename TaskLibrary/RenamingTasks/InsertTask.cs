using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class InsertTask : AbstractTask, IRenamingTask
  {
    private string insertValue = string.Empty;
    private int position = 0;

    public InsertTask()
    {
      InsertValue = String.Empty;
      Position = 0;
    }

    public string InsertValue { get { return insertValue; } set { insertValue = value; propertyChanged("InsertValue"); } }

    public int Position { get { return position; } set { position = value; propertyChanged("Position"); } }

    public void ApplyOn(FancyFile datei)
    {
      try
      {
        if (InsertValue.IsFilled() && Position >= 0 && Position < datei.NewFilename.Length)
          datei.NewFilename = datei.NewFilename.Insert(Position, InsertValue);
      }
      catch (Exception ex)
      {
        datei.IsValid = false;
      }
    }

    public IRenamingTask Self
    {
      get { return this; }
    }

    public override string Description
    {
      get { return String.Format("Insert text '{0}' at position '{1}'", insertValue.IsFilled() ? insertValue : "<empty>", position); }
    }

    public override string NameInTaskSelectionList
    {
      get { return "Insert text"; }
    }

    public override ITask GetNewInstance()
    {
      return new InsertTask();
    }


    public void ResetTask()
    {
      //nothing todo here!
    }
  }
}
