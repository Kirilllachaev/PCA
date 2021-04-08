using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;

using Microsoft.Win32.TaskScheduler;

namespace PCA
{
	static class Program
	{
		public static Form1 form1;
		public static Form3 form3;
		public static Form4 form4;
		public static bool UserIsCorrect;

		public static string a = "IYDgv1zkiw1GFEkSbbWpGn3yDhGluPwMuBA38ABw";
		public static string b = "https://mirea-e3916-default-rtdb.firebaseio.com/";
		public static string apiKey = "AIzaSyBRjtjT3kr3hS1bfrJUv6X4bnqfA9q_o6I";


		static IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
		{
			AuthSecret = a,
			BasePath = b
		};

		public static IFirebaseClient client;
		public static FirebaseAuthProvider auth;
		public static Timer tm;
		public static bool AutoStart;

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			SetAutorunValue(true);
			AutoStart = false;

			foreach (string S in args)
			{
				if (S.Contains("autostart"))
				{
					AutoStart = true;
					break;
				}
			}

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

			AutoStart = false;

		}


		public static void tm_Tick(object sender, EventArgs e)
		{
			MessageBox.Show("Сработало");
		}


		public static void ChoseForm()
		{
			if (!string.IsNullOrEmpty(Properties.Settings.Default.USID))
			{
				FirebaseResponse response1 = Program.client.Get("Users/" + Properties.Settings.Default.USID.ToString());
				Data result1 = response1.ResultAs<Data>();

				if (result1 != null)
				{
					Program.client.Set("Users/" + Properties.Settings.Default.USID.ToString() + "/Desktops/" + SystemInformation.ComputerName.ToString() +
						"/Story/" + DateTime.Now.ToShortTimeString(), "Включение | " + DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString());

					UserIsCorrect = true;
					form3 = new Form3();
					form3.Show();
				}
				else
				{
					form1 = new Form1();
					form1.Show();
				}

			}
			else
			{
				form1 = new Form1();
				form1.Show();
			}
		}



		public static void SetAutorunValue(bool autorun)
		{
			string name = "PCA_StartUp";
			string ExePath = System.Windows.Forms.Application.ExecutablePath;
			RegistryKey reg;
			reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			try
			{
				if (autorun)
					reg.SetValue(name, ExePath + " -autostart");
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
