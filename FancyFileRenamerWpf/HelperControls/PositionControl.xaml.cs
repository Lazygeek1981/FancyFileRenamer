﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FancyFileRenamer.TaskLibrary.RenamingTasks;

namespace FancyFileRenamerWpf.HelperControls
{
	/// <summary>
	/// Interaction logic for PositionControl.xaml
	/// </summary>
	public partial class PositionControl : UserControl
	{
		public TaskPositionPart TaskPositionPart { get; set; }

		public PositionControl()
		{
			InitializeComponent();
			TaskPositionPart = new TaskPositionPart();
			DataContext = TaskPositionPart;
		}
	}
}