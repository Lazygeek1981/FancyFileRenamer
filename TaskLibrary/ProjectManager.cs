using ExtendedXmlSerialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamer.TaskLibrary
{
	public class ProjectManager
	{
		private ExtendedXmlSerializer serializer = new ExtendedXmlSerializer();

		public void SaveToFile(Project project, string filename)
		{
			var xml = serializer.Serialize(project);

			File.WriteAllText(filename, xml);
		}

		public Project LoadFromFile(string filename)
		{
			string contentXml = File.ReadAllText(filename);

			Project loadedProject = serializer.Deserialize<Project>(contentXml);

			return loadedProject;
		}
	}
}
