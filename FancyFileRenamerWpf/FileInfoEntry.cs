using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFileRenamerWpf
{
	public class FileInfoEntry : INotifyPropertyChanged
	{
		private string key;
		private string value;

		public FileInfoEntry(string key, string value)
		{
			Key = key;
			Value = value;
		}

		public string Key { get { return key; } set { key = value; PropertyChanged(this, new PropertyChangedEventArgs("Key")); } }
		public string Value { get { return value; } set {this.value=value; PropertyChanged(this, new PropertyChangedEventArgs("Value"));} }


		public event PropertyChangedEventHandler PropertyChanged;
	}
}
