using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary.RenamingTasks
{
  public class InsertDateTask : AbstractTask, IRenamingTask
  {
    public enum Date { FileCreation, FileChanged, DateTimeDigitized, DateTimeOriginal, GPSTimestamp }

    public Date DateToInsert { get; set; }

    public int Position { get; set; }

    public string DateTimeFormat { get; set; }

    public InsertDateTask()
    {
      DateToInsert = Date.FileCreation;
      DateTimeFormat = "yyyy-MM-dd HH-mm";
      Position = 0;

    }

    public void ApplyOn(File datei)
    {
      
    }

    public IRenamingTask Self
    {
      get { return this; }
    }

    public IRenamingTask GetNewInstance()
    {
      return new InsertDateTask();
    }

    public void ResetTask()
    {
      DateToInsert = Date.FileCreation;
      DateTimeFormat = "yyyy-MM-dd HH-mm";
      Position = 0;
    }

    public override string Description
    {
      get { return String.Format("Insert Timestamp with format '{0}' at position '{1}'", Position, DateTimeFormat); }
    }
  }
}
