using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer
{
  public interface ITaskEditControl
  {
    void UpdateTaskFromControl();

    void SetTaskToControl(ITask task);

    event TaskChangedEventHandler TaskChanged;
  }
}
