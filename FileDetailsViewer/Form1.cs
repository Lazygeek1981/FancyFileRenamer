using FancyFileRenamer.TaskLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDetailsViewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var fileinfo = new System.IO.FileInfo(txtFile.Text);

			File file = new File(fileinfo.FullName);
			
			Image image = new Bitmap(txtFile.Text);

			ExifNET.Exif exif = new ExifNET.Exif(image.PropertyItems);

			var test = Devtist.Image.ImageProcessor.RetrieveMetadata(txtFile.Text);

			propertyGrid1.SelectedObject = file;
		}


	}
}
