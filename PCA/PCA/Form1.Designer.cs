namespace PCA
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.jText_Box1 = new JTextBox.JText_Box();
			this.jText_Box2 = new JTextBox.JText_Box();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
			this.Enter_Button = new ePOSOne.btnProduct.Button_WOC();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// jText_Box1
			// 
			this.jText_Box1.BorderColor = System.Drawing.Color.White;
			this.jText_Box1.BorderThickness = 1;
			this.jText_Box1.Cursor = System.Windows.Forms.Cursors.Cross;
			this.jText_Box1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jText_Box1.FontStyles = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jText_Box1.ForeColor = System.Drawing.Color.White;
			this.jText_Box1.Location = new System.Drawing.Point(33, 192);
			this.jText_Box1.Margin = new System.Windows.Forms.Padding(5);
			this.jText_Box1.MaxLength = 30;
			this.jText_Box1.Name = "jText_Box1";
			this.jText_Box1.onFocusBorderColor = System.Drawing.Color.Gainsboro;
			this.jText_Box1.PasswordChar = '\0';
			this.jText_Box1.RoundedBorder = 0;
			this.jText_Box1.Size = new System.Drawing.Size(245, 45);
			this.jText_Box1.TabIndex = 14;
			this.jText_Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.jText_Box1.TextColor = System.Drawing.Color.White;
			this.jText_Box1.TextInput = "";
			this.jText_Box1.Load += new System.EventHandler(this.jText_Box1_Load);
			// 
			// jText_Box2
			// 
			this.jText_Box2.BorderColor = System.Drawing.Color.White;
			this.jText_Box2.BorderThickness = 1;
			this.jText_Box2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.jText_Box2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jText_Box2.FontStyles = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jText_Box2.ForeColor = System.Drawing.Color.White;
			this.jText_Box2.Location = new System.Drawing.Point(33, 262);
			this.jText_Box2.Margin = new System.Windows.Forms.Padding(5);
			this.jText_Box2.MaxLength = 30;
			this.jText_Box2.Name = "jText_Box2";
			this.jText_Box2.onFocusBorderColor = System.Drawing.Color.Gainsboro;
			this.jText_Box2.PasswordChar = '\0';
			this.jText_Box2.RoundedBorder = 0;
			this.jText_Box2.Size = new System.Drawing.Size(245, 45);
			this.jText_Box2.TabIndex = 15;
			this.jText_Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.jText_Box2.TextColor = System.Drawing.Color.White;
			this.jText_Box2.TextInput = "";
			this.jText_Box2.Load += new System.EventHandler(this.jText_Box2_Load);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox3.Image = global::PCA.Properties.Resources.lockicon;
			this.pictureBox3.Location = new System.Drawing.Point(33, 245);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(43, 45);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.pictureBox2.Image = global::PCA.Properties.Resources.Слой_2;
			this.pictureBox2.Location = new System.Drawing.Point(33, 180);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 45);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::PCA.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(65, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 127);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// button_WOC1
			// 
			this.button_WOC1.BorderColor = System.Drawing.Color.White;
			this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.button_WOC1.FlatAppearance.BorderSize = 0;
			this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_WOC1.Location = new System.Drawing.Point(50, 431);
			this.button_WOC1.Name = "button_WOC1";
			this.button_WOC1.OnClickedButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Silver;
			this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Silver;
			this.button_WOC1.Size = new System.Drawing.Size(209, 53);
			this.button_WOC1.TabIndex = 12;
			this.button_WOC1.Text = "Регистрация";
			this.button_WOC1.TextColor = System.Drawing.Color.White;
			this.button_WOC1.UseVisualStyleBackColor = true;
			this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click_1);
			// 
			// Enter_Button
			// 
			this.Enter_Button.BorderColor = System.Drawing.Color.White;
			this.Enter_Button.ButtonColor = System.Drawing.Color.White;
			this.Enter_Button.FlatAppearance.BorderSize = 0;
			this.Enter_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.Enter_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Enter_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Enter_Button.Location = new System.Drawing.Point(50, 376);
			this.Enter_Button.Name = "Enter_Button";
			this.Enter_Button.OnClickedButtonColor = System.Drawing.Color.Silver;
			this.Enter_Button.OnHoverBorderColor = System.Drawing.Color.LightGray;
			this.Enter_Button.OnHoverButtonColor = System.Drawing.Color.LightGray;
			this.Enter_Button.OnHoverTextColor = System.Drawing.Color.Black;
			this.Enter_Button.Size = new System.Drawing.Size(209, 49);
			this.Enter_Button.TabIndex = 11;
			this.Enter_Button.Text = "Войти";
			this.Enter_Button.TextColor = System.Drawing.Color.Black;
			this.Enter_Button.UseVisualStyleBackColor = true;
			this.Enter_Button.Click += new System.EventHandler(this.button_WOC3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(305, 530);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.jText_Box2);
			this.Controls.Add(this.jText_Box1);
			this.Controls.Add(this.button_WOC1);
			this.Controls.Add(this.Enter_Button);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowInTaskbar = false;
			this.Text = "Авторизация";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private ePOSOne.btnProduct.Button_WOC Enter_Button;
		private ePOSOne.btnProduct.Button_WOC button_WOC1;
		private JTextBox.JText_Box jText_Box1;
		private JTextBox.JText_Box jText_Box2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

