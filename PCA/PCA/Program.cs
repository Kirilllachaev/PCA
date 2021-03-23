using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PCA
{
	static class Program
	{
		public static string UsName;

		static IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "T5jdGMn2TRo9q9G6Ms3ieap5hUbjD28hGNXFPSC3",
			BasePath = "https://pca-mirea-default-rtdb.europe-west1.firebasedatabase.app/"
		};

		public static IFirebaseClient client;

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Properties.Settings.Default.

			try
			{
				client = new FireSharp.FirebaseClient(config);
			}
			catch
			{
				MessageBox.Show("Fail");
			}

			if (!string.IsNullOrEmpty(Properties.Settings.Default.UsName)) 
			{
				FirebaseResponse response1 = Program.client.Get("Users/" + Properties.Settings.Default.UsName.ToString());
				Data result1 = response1.ResultAs<Data>();

				if(result1 != null)
				{
					Application.Run(new Form3());
				}
				else
				{
					Application.Run(new Form1());
				}
			}
			else
			{
				Application.Run(new Form1());
			}
				

			

			
		}
	}
}
