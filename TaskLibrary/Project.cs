using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.RenamingTasks;

namespace FancyFileRenamer.TaskLibrary
{
  public class Project
  {
    private DirectoryInfo sourcePath = null;
    private List<IRenamingTask> renamingTasks = new List<IRenamingTask>();
    private TrulyObservableCollection<File> files = new TrulyObservableCollection<File>();
    private ObservableCollection<File> targetFiles = new ObservableCollection<File>();

    private void sourcePathChanged()
    {
      files.Clear();

      if (sourcePath.Exists)
        sourcePath.GetFiles().ToList().ForEach(x => files.Add(new File(x.FullName)));
    }


    public DirectoryInfo SourcePath { get { return sourcePath; } set { sourcePath = value; sourcePathChanged(); } }

    public TrulyObservableCollection<File> Files { get { return files; } set { files = value; } }

    //public List<File> TargetFiles { get { return targetFiles; } set { targetFiles = value; } }

    public List<IRenamingTask> RenamingTasks { get { return renamingTasks; } set { renamingTasks = value; renamingTasksChanged(); } }

    private void renamingTasksChanged()
    {
      ApplyTasks();
    }

    public void ApplyTasks()
    {
      foreach (File file in Files)
      {
        file.NewFilename = file.Filename;

        foreach (IRenamingTask task in renamingTasks)
        {
          task.ApplyOn(file);
        }
      }
    }
  }
}
