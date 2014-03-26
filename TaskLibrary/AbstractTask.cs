using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public abstract class AbstractTask : ITask
  {
    protected void changed()
    {
      if (Changed != null)
        Changed(this, EventArgs.Empty);
    }

    public event TaskChangedEventHandler Changed;
    
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    protected void propertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    }
  }
}
