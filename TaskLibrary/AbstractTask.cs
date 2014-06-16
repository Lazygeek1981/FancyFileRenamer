using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public abstract class AbstractTask : ITask
  {
    public abstract string NameInTaskSelectionList { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void propertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    public abstract string Description    {      get;    }
  }
}
