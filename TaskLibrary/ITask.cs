using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public interface ITask : INotifyPropertyChanged
  {
    string NameInTaskSelectionList { get; }

    string Description { get; }
  }
}
