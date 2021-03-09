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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(171, 407);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Или";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.textBox1.Location = new System.Drawing.Point(53, 227);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox1.Size = new System.Drawing.Size(278, 27);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Логин";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.textBox2.Location = new System.Drawing.Point(53, 272);
			this.textBox2.Name = "textBox2";
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox2.Size = new System.Drawing.Size(278, 27);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Пароль";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = global::PCA.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(86, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(223, 122);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.BackgroundImage = global::PCA.Properties.Resources.Button;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.button3.Location = new System.Drawing.Point(41, 338);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(300, 51);
			this.button3.TabIndex = 2;
			this.button3.Text = "Войти";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::PCA.Properties.Resources.Button_Dark;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(41, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(300, 49);
			this.button1.TabIndex = 0;
			this.button1.Text = "Регистрация";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(400, 540);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

