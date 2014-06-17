using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tests
{
  public class CreateDummyFiles
  {

    [Test]
    public void PrepareDirectoryAndCreateFiles()
    {
      string folder = @"C:\Demo";

      if (!Directory.Exists(folder))
        Directory.CreateDirectory(folder);

      for (int i = 1; i <= 100; i++)
      {
        string filename = Path.Combine(folder, String.Format("example{0:0000}.txt", i));

        if (!File.Exists(filename))
        {
          string content = createRandomContent();
          File.WriteAllText(filename, content);
        }
      }
    }

    private static Random random = new Random();

    private string createRandomContent()
    {
      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < random.Next(10000); i++)
        sb.AppendFormat("{0}{1}", words[random.Next(words.Length)], Environment.NewLine);

      return sb.ToString();
    }


    public string[] words = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "At", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "Stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "Lorem", "ipsum", "dolor", "sit", "amet", "Lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "At", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "Stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "Lorem", "ipsum", "dolor", "sit", "amet" };
  }
}
