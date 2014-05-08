using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;

namespace FancyFileRenamer.TaskLibrary
{
  public class File : INotifyPropertyChanged
  {
    private FileInfo fileinfo;
    private string newFilename;



    public File(string filepath)
    {
      fileinfo = new FileInfo(filepath);

      checkForImageFile();

      Filepath = filepath;
      Filename = Path.GetFileName(filepath);
      newFilename = Filename;
      IsValid = true;
    }

    private void checkForImageFile()
    {
      if (fileinfo != null && (fileinfo.Extension.ToLower() == ".jpeg" || fileinfo.Extension.ToLower() == ".jpg"))
      {
        using (ExifReader reader = new ExifReader(fileinfo.FullName))
        {
          DateTime date;

          if (reader.GetTagValue<DateTime>(ExifTags.DateTime, out date))
          {
            ExifPhotoCreationDate = date;
          }
        }
      }
    }

    public File Self { get { return this; } }

    public string Filepath { get; private set; }

    public string Filename { get; private set; }

    public string NewFilename { get { return newFilename; } set { newFilename = value; OnPropertyChanged(); } }

    public long? Size
    {
      get
      {
        if (fileinfo != null && fileinfo.Exists)
          return fileinfo.Length;
        else 
          return null;
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

    public override string ToString()
    {
      return "File: " + Filename + " --> " + NewFilename;
    }
  }
}
