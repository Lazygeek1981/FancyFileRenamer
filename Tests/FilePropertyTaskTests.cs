using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using NUnit.Framework;

namespace Tests
{
	public class FilePropertyTaskTests
	{
		[Test]
		public void InsertFilePropertyAtTheEndTest()
		{
			FilePropertyTask task = new FilePropertyTask();

			File file = new File("C:\readme.txt");



		}

		[Test]
		public void ParseDateTimeTest()
		{
			string propertyText = "";
			string text = "2015:05:02 09:12:27";

			DateTime dateTime = new DateTime();

			if (DateTime.TryParseExact(text, "yyyy:MM:dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime))
			{
				propertyText = dateTime.ToString("yyyy'-'MM'-'dd'T'HH'-'mm'-'ss");
			}


			else
				propertyText = "[EMPTY]";

			Assert.That(propertyText == "2015-05-02T09-12-27");
		}
	}
}
