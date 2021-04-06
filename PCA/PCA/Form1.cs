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
	public partial class Form1 : Form
	{

		

		public Form1()
		{
			InitializeComponent();
			//this.FormBorderStyle = FormBorderStyle.None;
			//this.MouseDown += new MouseEventHandler(Form1_MouseDown);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			
		}


		void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			//base.Capture = false;
			//Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			//this.WndProc(ref m);
		}



		private async void button_WOC3_Click(object sender, EventArgs e)
		{
			//Войти

			if (!(string.IsNullOrEmpty(jText_Box1.TextInput) && string.IsNullOrEmpty(jText_Box2.TextInput)))
			{
				var data = new Data
				{
					login = jText_Box1.TextInput,
					pass = jText_Box2.TextInput
				};


				FirebaseResponse response = Program.client.Get("Users/");
				Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();

				bool Already = false;
				bool usname = false;

				foreach (var get in result)
				{
					string nameR = get.Value.login;
					string passR = get.Value.pass;

					if (data.login == nameR)
					{
						usname = true;

						if (data.pass == passR)
						{

							FirebaseResponse response2 = Program.client.Get("Users/" + nameR + "/Desktops/");
							Dictionary<string, DeskTop> result2 = response.ResultAs<Dictionary<string, DeskTop>>();
							
							bool already = false;
							float baseindex = 0;

							

							foreach (var get2 in result2)
							{		
								baseindex++;

								if (get2.Value.Name == SystemInformation.ComputerName) 
								{
									
									already = true;
								}

							}

							if (!already)
							{
								baseindex++;
								var desk = new DeskTop()
								{
									Name = SystemInformation.ComputerName,
								};

								FirebaseResponse response3 = Program.client.Set("Users/" + nameR + "/Desktops/" + desk.Name, desk);
							}

							
							Properties.Settings.Default.UsName = data.login;
							Properties.Settings.Default.Save();
							Program.UserIsCorrect = true;

							Already = true;


							jText_Box2.TextInput = "";
							jText_Box1.TextInput = "";




							this.Close();
							Program.form3 = new Form3();
							Program.form3.Show();


							return;
						}
						
					}
				}

				if (!Already)
				{
					if (usname)
					{
						MessageBox.Show("Неверный пароль");
					}
					else
					{
						MessageBox.Show("Пользователь с таким именем не найден");
					}
					
				}


			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}

		}

		private async void button_WOC1_Click_1(object sender, EventArgs e)
		{
			//Регистрация
			if( !(string.IsNullOrEmpty(jText_Box1.TextInput) && string.IsNullOrEmpty(jText_Box2.TextInput)))
			{
				var data = new Data
				{
					login = jText_Box1.TextInput,
					pass = jText_Box2.TextInput
				};


				FirebaseResponse response = Program.client.Get("Users/");
				Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();


				bool Already = false;
				int baseIndex = 0;

				if(result != null)
				{
					foreach (var get in result)
					{
						string nameR = get.Value.login;
						baseIndex++;
						if (data.login == nameR)
						{
							Already = true;
						}
					}
				}
				else
				{
					Already = false;
				}
				

				if (Already)
				{
					MessageBox.Show("Пользователь с таким именем уже зарегистрирован");
				}
				else
				{
					baseIndex++;
					FirebaseResponse responseR = Program.client.Set("Users/" + data.login, data);

					var desk = new DeskTop()
					{
						Name = SystemInformation.ComputerName,
					};

					FirebaseResponse responseRa = Program.client.Set("Users/" + data.login + "/Desktops/" + desk.Name, desk);

					jText_Box2.TextInput = "";
					jText_Box1.TextInput = "";
					
					Properties.Settings.Default.UsName = data.login;
					Properties.Settings.Default.Save();
					Program.UserIsCorrect = true;


					this.Close();
					Program.form3 = new Form3();
					Program.form3.Show();

					return;

				}

				
			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}
			
		}

		private void jText_Box2_Load(object sender, EventArgs e)
		{

		}

		private void jText_Box1_Load(object sender, EventArgs e)
		{

		}



		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(e.CloseReason != CloseReason.WindowsShutDown)
			Program.form4.ShowNotification();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			
			
		}
	}
}
