using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public class File
  {
    private FileInfo fileinfo;

    public File(string filepath)
    {
      fileinfo = new FileInfo(filepath);
      Filepath = filepath;
      Filename = Path.GetFileName(filepath);
      NewFilename = Filename;
      IsValid = true;
    }

    public File Self { get { return this; } }

    public string Filepath { get; private set; }

    public string Filename { get; private set; }

    public string NewFilename { get; set; }

    public long Size
    {
      get
      {
        if (fileinfo != null)
          return fileinfo.Length;
        else 
          return -1;
      }
    }

    public DateTime CreationDate { get { return fileinfo.CreationTime; } }

    public DateTime LastWriteDate { get { return fileinfo.LastWriteTime; } }

    public void DoRename()
    {
      try
      {
        System.IO.File.Move(Filepath, Path.Combine(Path.GetDirectoryName(Filepath), NewFilename));
      }
      catch
      {
        IsValid = false;
      }
    }

    public bool IsValid { get; set; }
  }
}
