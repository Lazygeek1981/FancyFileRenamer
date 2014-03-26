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


    public EnumerateTask()
    {
      StartAt = 0;
      NumberFormat = "00";
      InsertAt = EnumerateNumberPosition.Start;
      CustomPosition = 0;
    }

    public int StartAt { get; set; }

    public string NumberFormat { get; set; }

    public EnumerateNumberPosition InsertAt { get; set; }

    public int CustomPosition { get; set; }

    protected int? currentCounter;

    protected int getNextCounter()
    {
      if (currentCounter == null)
        currentCounter = StartAt;
      else
        currentCounter++;

      return currentCounter.Value;
    }

    public void ApplyOn(File datei)
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

    public ITask Self
    {
      get { return this; }
    }

    public string Description
    {
      get { return "Enumerate"; }
    }

    public string NameInTaskSelectionList
    {
      get { return "Enumerate"; }
    }

    public ITask GetNewInstance()
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
