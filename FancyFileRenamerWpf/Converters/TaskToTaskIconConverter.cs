using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FancyFileRenamer.TaskLibrary;
using FancyFileRenamer.TaskLibrary.RenamingTasks;

namespace FancyFileRenamerWpf.Converters
{
	public class TaskToTaskIconConverter : IValueConverter
	{
		private static Dictionary<Type, BitmapSource> icons;

		#region IValueConverter Members

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (icons == null)
			{
				createIcons();
			}

			if (value == null || !(value is ITask))
				return null;
			else
				return icons[value.GetType()];
		}

		private void createIcons()
		{
			icons = new Dictionary<Type, BitmapSource>();
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.ReplaceTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_rename.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.ChangeFileExtensionTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_changeExtension.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.EnumerateTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_enumerate.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.ClearEntireFilenameTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_clear.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.InsertTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_insert.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.RenamingTasks.FilePropertyTask), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/task_insert.png"), UriKind.Absolute)));

			//TODO
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.SortingTasks.FilenameSorting), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/sort_filename.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.SortingTasks.SizeSorting), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/sort_filesize.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.SortingTasks.CreationDateSorting), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/sort_date.png"), UriKind.Absolute)));
			icons.Add(typeof(FancyFileRenamer.TaskLibrary.SortingTasks.ExifDateSorting), new BitmapImage(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "Images/sort_exif.png"), UriKind.Absolute)));
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
