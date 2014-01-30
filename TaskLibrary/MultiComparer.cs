using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
  public class MultiComparer : IComparer<File>
  {
    private readonly IComparer<File>[] _comparers;

    public MultiComparer(params IComparer<File>[] comparers)
    {
      _comparers = comparers;
    }

    public int Compare(File x, File y)
    {
      int retVal = 0, i = 0;

      while (retVal == 0 && i < _comparers.Length)
        retVal = _comparers[i++].Compare(x, y);

      return retVal;
    }
  } 
}
