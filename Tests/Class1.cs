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
  public class TaskTests
  {
    [Test]
    public void ChangeFileExtensionTest()
    {
      ChangeFileExtensionTask task = new ChangeFileExtensionTask();

      File file = new File(@"D:\readme.txt");

      task.NewExtension = "bmp";

      task.ApplyOn(file);

      Assert.That(file.newFilename, Is.EqualTo(@"readme.bmp"));
    }

    [Test]
    public void ChangeFileExtensionWithDotTest()
    {
      ChangeFileExtensionTask task = new ChangeFileExtensionTask();

      File file = new File(@"D:\readme.txt");

      task.NewExtension = ".bmp";

      task.ApplyOn(file);

      Assert.That(file.newFilename, Is.EqualTo(@"readme.bmp"));
    }

    [Test]
    public void ReplaceTest()
    {
      ReplaceTask task = new ReplaceTask();

      File file = new File(@"D:\readme.txt");

      task.SearchFor = "readme";

      task.ReplaceWith = "readme-carefully";

      task.ApplyOn(file);

      Assert.That(file.newFilename, Is.EqualTo(@"readme-carefully.txt"));
    }
  }
}
