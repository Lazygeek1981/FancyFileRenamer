using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer
{
  public interface ITask
  {
    void ApplyOn(File datei);

    ITask Self { get; }

    string Description { get; }

    string NameInTaskSelectionList { get; }

    ITask GetNewInstance();

    void ResetTask();
  }
}
