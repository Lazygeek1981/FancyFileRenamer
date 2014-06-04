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
using FancyFileRenamer.TaskLibrary;

namespace FancyFileRenamerWpf
{
  /// <summary>
  /// Interaction logic for FileInfoWindow.xaml
  /// </summary>
  public partial class FileInfoWindow : Window
  {
    public FileInfoWindow()
    {
      InitializeComponent();

      DataContext = this;

      CurrentEntries = new List<Entry>();
    }

    public void SetFile(File file)
    {
      CurrentEntries.Clear();

      

    }

    public List<Entry> CurrentEntries { get; set; }

    public class Entry
    {
      public string Key { get; set; }
      public string Value { get; set; }
    }
  }
}
