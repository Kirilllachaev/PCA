﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PCA
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Program.ChoseForm();
			notifyIcon1.Visible = false;
		}


		public void ShowNotification()
		{
			notifyIcon1.Visible = true;
			
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			if (Program.UserIsCorrect) 
			{
				if (Environment.TickCount < 10000)
				{
					Program.client.Set("Users/" + Properties.Settings.Default.UsName.ToString() + "/Desktops/" + SystemInformation.ComputerName.ToString() + "/Story/Включение", DateTime.Now.AddMilliseconds(-Environment.TickCount));
				}
			}
			
		}

		private void Form4_Shown(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form4_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.WindowsShutDown)
			{
				if (Program.UserIsCorrect) 
				{
					Program.client.Set("Users/" + Properties.Settings.Default.UsName.ToString() + "/Desktops/" + SystemInformation.ComputerName.ToString() + "/Story/Выключение", DateTime.Now);
				}
				
			}
		}
	}
}
