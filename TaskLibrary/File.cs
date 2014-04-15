using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public class File : INotifyPropertyChanged
  {
    private FileInfo fileinfo;
    private string newFilename;

    public File(string filepath)
    {
      fileinfo = new FileInfo(filepath);
      Filepath = filepath;
      Filename = Path.GetFileName(filepath);
      newFilename = Filename;
      IsValid = true;
    }

    public File Self { get { return this; } }

    public string Filepath { get; private set; }

    public string Filename { get; private set; }

    public string NewFilename { get { return newFilename; } set { newFilename = value; OnPropertyChanged(); } }

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

    public DateTime? ExifPhotoCreationDate { get; set; }

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

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged()
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs("NewFilename"));
    }
  }
}
