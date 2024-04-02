using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Wiggler
{
	public partial class MainForm : Form
	{
		private static Timer timer;
		private static bool isRunning = false;

		public MainForm()
		{
			InitializeComponent();

			timer = new Timer();
			timer.Interval = 10000;
			timer.Tick += new EventHandler(Wiggle);
		}

		private void Wiggle(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int x = Cursor.Position.X;
			int y = Cursor.Position.Y;

			x += rnd.Next(-10, 10);
			y += rnd.Next(-10, 10);

			Cursor.Position = new Point(x, y);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnToggle_Click(object sender, EventArgs e)
		{
			isRunning = !isRunning;

			if (isRunning)
			{
				btnToggle.Text = "Stop";
				timer.Start();
			}
			else
			{
				btnToggle.Text = "Start";
				timer.Stop();
			}
		}
	}
}

