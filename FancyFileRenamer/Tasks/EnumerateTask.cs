using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.Tasks
{
  public enum NumberPosition { Start, End, Custom }

  public class EnumerateTask : ITask
  {
    public EnumerateTask()
    {
      StartAt = 0;
      NumberFormat = "00";
      InsertAt = NumberPosition.Start;
      CustomPosition = 0;
    }

    public int StartAt { get; set; }

    public string NumberFormat { get; set; }

    public NumberPosition InsertAt { get; set; }

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
          case NumberPosition.Start:
            datei.newFilename = number + datei.newFilename;
            break;
          case NumberPosition.End:
            datei.newFilename = Path.GetFileNameWithoutExtension(datei.newFilename) + number + Path.GetExtension(datei.newFilename);
            break;
          case NumberPosition.Custom:
            datei.newFilename = datei.newFilename.Insert(CustomPosition, number);
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
}
