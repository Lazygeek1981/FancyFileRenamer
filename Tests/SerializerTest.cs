using ExtendedXmlSerialization;
using FancyFileRenamer.TaskLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
	public class SerializerTest
	{
		[Test]
		public void SerializeAProject()
		{
			Project project = new Project();

			project.SourcePath = @"D:\temp";
			project.RenamingTasks.Add(new FancyFileRenamer.TaskLibrary.RenamingTasks.InsertTask { InsertValue = "demo", Position = 0 });
			project.RenamingTasks.Add(new FancyFileRenamer.TaskLibrary.RenamingTasks.ReplaceTask { SearchFor = "demo", ReplaceWith = "" });

			ExtendedXmlSerializer serializer = new ExtendedXmlSerializer();
			
			var xml = serializer.Serialize(project);

			Project loadedProject = serializer.Deserialize<Project>(xml);

			Assert.That(loadedProject.RenamingTasks.Count, Is.EqualTo(project.RenamingTasks.Count));

			Assert.That(loadedProject.RenamingTasks[0].GetType().Name, Is.EqualTo(project.RenamingTasks[0].GetType().Name));
		}
	}
}
