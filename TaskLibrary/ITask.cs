using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public interface ITask
  {
    event TaskChangedEventHandler Changed;
  }
}
