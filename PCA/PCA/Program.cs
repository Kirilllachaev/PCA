using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;

namespace PCA
{
	static class Program
	{
		public static Form1 form1;
		public static Form3 form3;
		public static Form4 form4;


		static IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "IYDgv1zkiw1GFEkSbbWpGn3yDhGluPwMuBA38ABw",
			BasePath = "https://mirea-e3916-default-rtdb.firebaseio.com/"
		};

		public static IFirebaseClient client;
		public static Timer tm;

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			SetAutorunValue(true);
			Properties.Settings.Default.Desktop = "Yes";

			tm = new Timer();
			tm.Enabled = true;
			tm.Interval = 60000;//пять минут в милисекундах
			tm.Tick += new EventHandler(tm_Tick);

			try
			{
				client = new FireSharp.FirebaseClient(config);
			}
			catch
			{
				MessageBox.Show("Fail");
			}


			ChoseForm();
			form4 = new Form4();
			Application.Run(form4);

		}

		
		

		public static void tm_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Сработало");
		}


		public static void ChoseForm()
		{

			if (!string.IsNullOrEmpty(Properties.Settings.Default.UsName))
			{
				FirebaseResponse response1 = Program.client.Get("Users/" + Properties.Settings.Default.UsName.ToString());
				Data result1 = response1.ResultAs<Data>();

				if (result1 != null)
				{
					form3 = new Form3();
					form3.Show();
					//Application.Run(form3);
				}
				else
				{
					form1 = new Form1();
					form1.Show();
					//Application.Run(form1);	
				}
			}
			else
			{
				form1 = new Form1();
				form1.Show();
				//Application.Run(form1);
			}
		}

		public static void SetAutorunValue(bool autorun)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.Desktop))
			{
				string name = "PCAApp";
				string ExePath = System.Windows.Forms.Application.ExecutablePath;
				RegistryKey reg;
				reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
				try
				{
					if (autorun)
						reg.SetValue(name, ExePath);
					else
						reg.DeleteValue(name);

					reg.Close();
				}
				catch
				{
					MessageBox.Show("Не удалось добавить в автозапуск");
				}
				
			}
			
		}
	}
}
