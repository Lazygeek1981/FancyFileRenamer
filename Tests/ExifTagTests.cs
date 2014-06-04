using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifLib;
using NUnit.Framework;

namespace Tests
{
  public class ExifTagTests
  {
    [Test]
    public void CastAllTagsAsObjectTest()
    {
      Dictionary<ExifTags, string> tags = new Dictionary<ExifTags, string>();

      using (ExifReader reader = new ExifReader(@"D:\testfotos\P1050814.JPG"))
      {
        foreach (var value in Enum.GetValues(typeof(ExifLib.ExifTags)))
        {
          object result = null;

          if (reader.GetTagValue<object>((ExifTags)value, out result))
          {
            tags.Add((ExifTags)value, result.ToString());
          }
          else
            tags.Add((ExifTags)value, String.Empty);
        }
      }
    }
  }
}
