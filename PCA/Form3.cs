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

			//this.FormBorderStyle = FormBorderStyle.None;
			//this.MouseDown += new MouseEventHandler(Form3_MouseDown);

			if (Program.UserIsCorrect && Program.AutoStart)
			{

				if (Program.UserIsCorrect)
				{
					Program.client.Set("Users/" + Properties.Settings.Default.USID.ToString() + "/Desktops/" + SystemInformation.ComputerName.ToString() +
						"/Story/" + DateTime.Now.ToShortTimeString(), "Включение | " + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());
				}
				Program.AutoStart = false;

			}

			if (Program.UserIsCorrect)
            {
				label1.Text = Properties.Settings.Default.UsName;
				label2.Text = SystemInformation.ComputerName;

				FirebaseResponse response = Program.client.Get("Users/" + 
					Properties.Settings.Default.USID + "/Desktops/" + SystemInformation.ComputerName + "/Story");
				Dictionary<string, string> result2 = response.ResultAs<Dictionary<string, string>>();

				if(result2 != null)
				{
					List<string> SS = new List<string>();
					
					foreach (var get2 in result2)
					{
						SS.Add(get2.Value.ToString());
					}

					SS.Reverse();

					foreach (string S in SS)
					{
						var tx = new Label();
						tx.Text = S;
						tx.ForeColor = Color.White;
						tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Regular);
						tx.Size = new Size(195, 25);
						tx.Margin = new Padding(10, 10, 0, 0);
						flowLayoutPanel1.Controls.Add(tx);
					}

					
				}


			}
            else
            {
				MessageBox.Show("Error");
            }

			

			

		}

		void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			//base.Capture = false;
			//Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			//this.WndProc(ref m);
		}


		private void button_WOC1_Click(object sender, EventArgs e)
		{
			//FirebaseResponse response1 = Program.client.Delete("Users/" + Properties.Settings.Default.UsName.ToString()  + "/Desktops/" + SystemInformation.ComputerName);
			//Data result1 = response1.ResultAs<Data>();

			Properties.Settings.Default.UsName = "";
			Properties.Settings.Default.USID = "";
			Properties.Settings.Default.Save();
			Program.UserIsCorrect = false;

			this.Close();
			Program.form1 = new Form1();
			Program.form1.Show();

		}


		private void Form3_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (e.CloseReason != CloseReason.WindowsShutDown)
				Program.form4.ShowNotification();




		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
