using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.SortingTasks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
  public class FileSortingTests
  {


    [Test]
    public void SortByNameTest()
    {
      List<File> files = new List<File> { new File(@"bbbb.txt"), new File(@"aaaa.txt") };
      FilenameSorting filenameSorter = new FilenameSorting();

      MultiComparer sorter = new MultiComparer(filenameSorter);

      files.Sort(sorter);

      Assert.That(files[0].Filename, Is.EqualTo("aaaa.txt"));
    }
  }
}
