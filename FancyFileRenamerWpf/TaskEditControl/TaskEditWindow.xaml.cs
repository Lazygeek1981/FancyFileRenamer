using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FancyFileRenamerWpf.TaskEditControl
{
	/// <summary>
	/// Interaction logic for TaskEditWindow.xaml
	/// </summary>
	public partial class TaskEditWindow : Window
	{
		public TaskEditWindow()
		{
			InitializeComponent();
		}

		public void SetTaskEditingUserControl(ChangeFileExtensionUserControl uc)
		{
			Content.Content = uc;
		}
	}
}
