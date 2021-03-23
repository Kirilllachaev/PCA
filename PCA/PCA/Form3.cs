using System;
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
	public partial class Form3 : Form
	{
		public Form3()
		{

			InitializeComponent();


			
			FirebaseResponse response1 = Program.client.Get("Users/" + Properties.Settings.Default.UsName.ToString());
			Data result1 = response1.ResultAs<Data>();
			

			label1.Text = result1.login;
		
			label2.Text = SystemInformation.ComputerName;

			this.FormBorderStyle = FormBorderStyle.None;
			this.MouseDown += new MouseEventHandler(Form3_MouseDown);

		}

		void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button_WOC1_Click(object sender, EventArgs e)
		{
			//Добавить ПК
			//Environment.MachineName;

			FirebaseResponse response1 = Program.client.Delete("Users/" + Properties.Settings.Default.UsName.ToString()  + "/Desktops/" + SystemInformation.ComputerName);
			Data result1 = response1.ResultAs<Data>();

			Properties.Settings.Default.UsName = "";
			Properties.Settings.Default.Save();


			Form1 form1 = new Form1();
			this.Hide();
			form1.ShowDialog();
		}
	}
}
