using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer
{
  public class File
  {
    public File(string filepath)
    {
      Filepath = filepath;
      Filename = Path.GetFileName(filepath);
      newFilename = Filename;
    }

    public File Self { get { return this; } }

    public string Filepath { get; private set; }

    public string Filename { get; private set; }

    public string newFilename { get; set; }

    public void DoRename()
    {
      try
      {
        System.IO.File.Move(Filepath, Path.Combine(Path.GetDirectoryName(Filepath), newFilename));
      }
      catch
      {
        IsValid = false;
      }
    }

    public bool IsValid { get; set; }
  }
}
