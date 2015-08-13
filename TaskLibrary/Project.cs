using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyFileRenamer.TaskLibrary.RenamingTasks;
using FancyFileRenamer.TaskLibrary.SortingTasks;

namespace FancyFileRenamer.TaskLibrary
{
	public class Project
	{
		private DirectoryInfo sourcePath = null;
		private List<IRenamingTask> renamingTasks = new List<IRenamingTask>();
		private List<ISortingTask> sortingTasks = new List<ISortingTask>();

		private TrulyObservableCollection<FancyFile> files = new TrulyObservableCollection<FancyFile>();

		private void sourcePathChanged()
		{
			files.Clear();

			if (sourcePath.Exists)
				sourcePath.GetFiles().ToList().ForEach(x => files.Add(new FancyFile(x.FullName)));
		}


		public DirectoryInfo SourcePath { get { return sourcePath; } set { sourcePath = value; sourcePathChanged(); } }

		public TrulyObservableCollection<FancyFile> Files { get { return files; } set { files = value; } }

		//public List<File> TargetFiles { get { return targetFiles; } set { targetFiles = value; } }

		public List<IRenamingTask> RenamingTasks { get { return renamingTasks; } set { renamingTasks = value; renamingTasksChanged(); } }

		public List<ISortingTask> SortingTasks { get { return sortingTasks; } set { sortingTasks = value; sortingTasksChanged(); } }

		private void sortingTasksChanged()
		{
			SortFiles();
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
	}
}
