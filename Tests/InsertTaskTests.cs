using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer;
using FancyFileRenamer.Tasks;
using NUnit.Framework;

namespace Tests
{
  
  public class InsertTaskTests
  {
    public void InsertAtTheBeginningTest()
    {
      InsertTask task = new InsertTask();

      File file = new File(@"D:\readme.txt");

      task.InsertValue = "TEST";
      task.Position = 0;

      task.ApplyOn(file);

      Assert.That(file.newFilename, Is.EqualTo(@"TESTreadme.txt"));
    }
  }
}
