using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public class Project
  {
    private DirectoryInfo sourcePath = null;

    public DirectoryInfo SourcePath { get { return sourcePath; } set { sourcePath = value; sourcePathChanged(); } }

    

    private void sourcePathChanged()
    {
      
    }
  }
}
