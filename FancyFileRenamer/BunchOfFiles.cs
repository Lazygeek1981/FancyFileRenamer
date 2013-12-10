using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer
{
  public class BunchOfFiles
  {
    public BunchOfFiles()
    {
      Files = new List<File>();     
    }

    public List<File> Files { get; set; }

    public void SetAllToValid()
    {
      Files.ForEach(x => x.IsValid = true);
    }

    public void ApplyTasks(List<ITask> tasks)
    {
      foreach (File file in Files)
      {
        file.newFilename = file.Filename;

        Console.WriteLine(file.newFilename);

        foreach (ITask task in tasks)
        {
          task.ApplyOn(file);
          Console.WriteLine(file.newFilename);
        }
      }
    }

    public void CheckForCollisions()
    {
      foreach (File file in Files)
      {
        foreach (File otherFile in Files)
        {
          if (file.newFilename == otherFile.newFilename)
          {
            file.IsValid = false;
            break;
          }
        }
      }
    }

    public void DoRename()
    {
      Files.ForEach(x => x.DoRename());
    }

  }
}
