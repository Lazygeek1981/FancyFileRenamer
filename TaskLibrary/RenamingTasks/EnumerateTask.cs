using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class EnumerateTask : AbstractTask, IRenamingTask
  {
    private int startAt = 0;
    private string numberFormat = "00";
    private EnumerateNumberPosition insertAt = EnumerateNumberPosition.Start;
    private int customPosition = 0;

    public EnumerateTask()
    {
      //nothing todo here
    }

    public int StartAt { get { return startAt; } set { startAt = value; propertyChanged("StartAt"); } }

    public string NumberFormat { get { return numberFormat; } set { numberFormat = value; propertyChanged("NumberFormat"); } }

    public EnumerateNumberPosition InsertAt { get { return insertAt; } set { insertAt = value; propertyChanged("InsertAt"); } }

    public int CustomPosition { get { return customPosition; } set { customPosition = value; propertyChanged("CustomPosition"); } }

    protected int? currentCounter;

    protected int getNextCounter()
    {
      if (currentCounter == null)
        currentCounter = StartAt;
      else
        currentCounter++;

      return currentCounter.Value;
    }

    public void ApplyOn(FancyFile datei)
    {
      try
      {
        string number = getNextCounter().ToString(NumberFormat);

        switch (InsertAt)
        {
          case EnumerateNumberPosition.Start:
            datei.NewFilename = number + datei.NewFilename;
            break;
          case EnumerateNumberPosition.End:
            datei.NewFilename = Path.GetFileNameWithoutExtension(datei.NewFilename) + number + Path.GetExtension(datei.NewFilename);
            break;
          case EnumerateNumberPosition.Custom:
            datei.NewFilename = datei.NewFilename.Insert(CustomPosition, number);
            break;
        }
      }
      catch
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
      get { return "Enumerate"; }
    }

    public override string NameInTaskSelectionList
    {
      get { return "Enumerate"; }
    }

    public override ITask GetNewInstance()
    {
      return new EnumerateTask();
    }

    public void ResetTask()
    {
      currentCounter = null;
    }
  }

  public enum EnumerateNumberPosition { Start, End, Custom }
}
