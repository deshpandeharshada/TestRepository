using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace TestAutoUpdate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			AutoUpdater.Start(@"D:\Business\TestAutoUpdate\TestAutoUpdate\Updater\AutoUpdaterTest.xml");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "This is version " + this.ProductVersion + " updated from git";
		}
	}
}
