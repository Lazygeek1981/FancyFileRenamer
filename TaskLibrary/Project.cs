using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using FancyFileRenamer.TaskLibrary.SortingTasks;
using System.Xml.Serialization;

namespace FancyFileRenamer.TaskLibrary
{
	[Serializable]
	public class Project
	{
		private DirectoryInfo sourceDirectory = new DirectoryInfo(@"C:\");
		private List<IRenamingTask> renamingTasks = new List<IRenamingTask>();
		private List<ISortingTask> sortingTasks = new List<ISortingTask>();
		private TrulyObservableCollection<FancyFile> files = new TrulyObservableCollection<FancyFile>();


		private void sourcePathChanged()
		{
			files.Clear();

			if (sourceDirectory.Exists)
				sourceDirectory.GetFiles().ToList().ForEach(x => files.Add(new FancyFile(x.FullName)));
		}

		public string SourcePath { get; set; }

		[XmlIgnore]
		public DirectoryInfo SourceDirectory { get { return new DirectoryInfo(SourcePath); } }

		[XmlIgnore]
		public TrulyObservableCollection<FancyFile> Files { get { return files; } set { files = value; } }

		public List<IRenamingTask> RenamingTasks { get { return renamingTasks; } set { renamingTasks = value; renamingTasksChanged(); } }

		public List<ISortingTask> SortingTasks { get { return sortingTasks; } set { sortingTasks = value; sortingTasksChanged(); } }

		private void sortingTasksChanged()
		{
			SortFiles();
		}

		public void LoadFiles()
		{
			sourcePathChanged();
		}

		public void SortFiles()
		{
			MultiComparer comparer = new MultiComparer(SortingTasks.ToArray());

			List<FancyFile> newFiles = files.ToList();

			newFiles.Sort(comparer);

			Files = new TrulyObservableCollection<FancyFile>(newFiles);
		}

		private void renamingTasksChanged()
		{
			ApplyTasks();
		}

		public void ApplyTasks()
		{
			renamingTasks.ForEach(x => x.ResetTask());

			foreach (FancyFile file in Files)
			{
				if (!file.IsSelected)
					continue;

				file.NewFilename = file.Filename;

				foreach (IRenamingTask task in renamingTasks)
				{
					task.ApplyOn(file);
				}
			}
		}

		public void DoRenaming()
		{
			StringBuilder sb = new StringBuilder();

			foreach (FancyFile file in Files)
			{
				if (!file.IsSelected)
					continue;

				try
				{
					sb.AppendLine(String.Format("{0} ----> {1}", file.Filename, file.NewFilename));
					file.DoRename();
				}
				catch (Exception ex)
				{
					sb.AppendLine(String.Format("{0} --  ERROR --> {1}", file.Filename, ex.GetType().ToString()));
				}
			}
		}

		public string SavePath { get; set; }
	}
}
