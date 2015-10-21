namespace HostAdderXampp
{
	partial class main
	{
		/// <summary>
		/// Требуется переменная конструктора.
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
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
			this.title = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.input_host = new System.Windows.Forms.TextBox();
			this.delete = new System.Windows.Forms.Button();
			this.example_host = new System.Windows.Forms.Label();
			this.pick_xampp = new System.Windows.Forms.Button();
			this.pick_project = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.default_xampp = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Label();
			this.label_xampp = new System.Windows.Forms.Label();
			this.label_project = new System.Windows.Forms.Label();
			this.status_host = new System.Windows.Forms.Label();
			this.status_project = new System.Windows.Forms.Label();
			this.status_xampp = new System.Windows.Forms.Label();
			this.status_win = new System.Windows.Forms.Label();
			this.label_win = new System.Windows.Forms.Label();
			this.default_win = new System.Windows.Forms.Button();
			this.pick_win = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(30, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(238, 13);
			this.title.TabIndex = 0;
			this.title.Text = "Вам останется только перезапустить apache";
			// 
			// add
			// 
			this.add.Enabled = false;
			this.add.Location = new System.Drawing.Point(33, 209);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(120, 37);
			this.add.TabIndex = 1;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// input_host
			// 
			this.input_host.Location = new System.Drawing.Point(33, 25);
			this.input_host.Name = "input_host";
			this.input_host.Size = new System.Drawing.Size(168, 20);
			this.input_host.TabIndex = 2;
			this.input_host.TextChanged += new System.EventHandler(this.input_host_Leave);
			this.input_host.Leave += new System.EventHandler(this.input_host_Leave);
			// 
			// delete
			// 
			this.delete.Enabled = false;
			this.delete.Location = new System.Drawing.Point(159, 209);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(120, 37);
			this.delete.TabIndex = 3;
			this.delete.Text = "Удалить";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// example_host
			// 
			this.example_host.AutoSize = true;
			this.example_host.Location = new System.Drawing.Point(207, 28);
			this.example_host.Name = "example_host";
			this.example_host.Size = new System.Drawing.Size(61, 13);
			this.example_host.TabIndex = 4;
			this.example_host.Text = "mysite.local";
			// 
			// pick_xampp
			// 
			this.pick_xampp.Location = new System.Drawing.Point(33, 104);
			this.pick_xampp.Name = "pick_xampp";
			this.pick_xampp.Size = new System.Drawing.Size(168, 24);
			this.pick_xampp.TabIndex = 5;
			this.pick_xampp.Text = "Выберите путь до xampp";
			this.pick_xampp.UseVisualStyleBackColor = true;
			this.pick_xampp.Click += new System.EventHandler(this.pick_xampp_Click);
			// 
			// pick_project
			// 
			this.pick_project.Location = new System.Drawing.Point(33, 155);
			this.pick_project.Name = "pick_project";
			this.pick_project.Size = new System.Drawing.Size(168, 24);
			this.pick_project.TabIndex = 6;
			this.pick_project.Text = "Путь до проекта";
			this.pick_project.UseVisualStyleBackColor = true;
			this.pick_project.Click += new System.EventHandler(this.pick_project_Click);
			// 
			// default_xampp
			// 
			this.default_xampp.Location = new System.Drawing.Point(207, 104);
			this.default_xampp.Name = "default_xampp";
			this.default_xampp.Size = new System.Drawing.Size(72, 24);
			this.default_xampp.TabIndex = 7;
			this.default_xampp.Text = "c:\\xampp";
			this.default_xampp.UseVisualStyleBackColor = true;
			this.default_xampp.Click += new System.EventHandler(this.default_xampp_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.result.Location = new System.Drawing.Point(30, 254);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(123, 13);
			this.result.TabIndex = 8;
			this.result.Text = "Здесь будет результат";
			// 
			// label_xampp
			// 
			this.label_xampp.AutoSize = true;
			this.label_xampp.Location = new System.Drawing.Point(31, 136);
			this.label_xampp.Name = "label_xampp";
			this.label_xampp.Size = new System.Drawing.Size(0, 13);
			this.label_xampp.TabIndex = 9;
			// 
			// label_project
			// 
			this.label_project.AutoSize = true;
			this.label_project.Location = new System.Drawing.Point(31, 187);
			this.label_project.Name = "label_project";
			this.label_project.Size = new System.Drawing.Size(0, 13);
			this.label_project.TabIndex = 10;
			// 
			// status_host
			// 
			this.status_host.AutoSize = true;
			this.status_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.status_host.Location = new System.Drawing.Point(8, 17);
			this.status_host.Name = "status_host";
			this.status_host.Size = new System.Drawing.Size(23, 31);
			this.status_host.TabIndex = 11;
			this.status_host.Text = "•";
			// 
			// status_project
			// 
			this.status_project.AutoSize = true;
			this.status_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.status_project.Location = new System.Drawing.Point(8, 151);
			this.status_project.Name = "status_project";
			this.status_project.Size = new System.Drawing.Size(23, 31);
			this.status_project.TabIndex = 12;
			this.status_project.Text = "•";
			// 
			// status_xampp
			// 
			this.status_xampp.AutoSize = true;
			this.status_xampp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.status_xampp.Location = new System.Drawing.Point(8, 101);
			this.status_xampp.Name = "status_xampp";
			this.status_xampp.Size = new System.Drawing.Size(23, 31);
			this.status_xampp.TabIndex = 13;
			this.status_xampp.Text = "•";
			// 
			// status_win
			// 
			this.status_win.AutoSize = true;
			this.status_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.status_win.Location = new System.Drawing.Point(8, 48);
			this.status_win.Name = "status_win";
			this.status_win.Size = new System.Drawing.Size(23, 31);
			this.status_win.TabIndex = 17;
			this.status_win.Text = "•";
			// 
			// label_win
			// 
			this.label_win.AutoSize = true;
			this.label_win.Location = new System.Drawing.Point(31, 83);
			this.label_win.Name = "label_win";
			this.label_win.Size = new System.Drawing.Size(0, 13);
			this.label_win.TabIndex = 16;
			// 
			// default_win
			// 
			this.default_win.Location = new System.Drawing.Point(207, 51);
			this.default_win.Name = "default_win";
			this.default_win.Size = new System.Drawing.Size(72, 24);
			this.default_win.TabIndex = 15;
			this.default_win.Text = "c:\\";
			this.default_win.UseVisualStyleBackColor = true;
			this.default_win.Click += new System.EventHandler(this.default_win_Click);
			// 
			// pick_win
			// 
			this.pick_win.Location = new System.Drawing.Point(33, 51);
			this.pick_win.Name = "pick_win";
			this.pick_win.Size = new System.Drawing.Size(168, 24);
			this.pick_win.TabIndex = 14;
			this.pick_win.Text = "Выберите путь до windows";
			this.pick_win.UseVisualStyleBackColor = true;
			this.pick_win.Click += new System.EventHandler(this.pick_win_Click);
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 275);
			this.Controls.Add(this.status_win);
			this.Controls.Add(this.label_win);
			this.Controls.Add(this.default_win);
			this.Controls.Add(this.pick_win);
			this.Controls.Add(this.status_xampp);
			this.Controls.Add(this.status_project);
			this.Controls.Add(this.status_host);
			this.Controls.Add(this.label_project);
			this.Controls.Add(this.label_xampp);
			this.Controls.Add(this.result);
			this.Controls.Add(this.default_xampp);
			this.Controls.Add(this.pick_project);
			this.Controls.Add(this.pick_xampp);
			this.Controls.Add(this.example_host);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.input_host);
			this.Controls.Add(this.add);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "main";
			this.Text = "HostAdder";
			this.Click += new System.EventHandler(this.main_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.TextBox input_host;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Label example_host;
		private System.Windows.Forms.Button pick_xampp;
		private System.Windows.Forms.Button pick_project;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button default_xampp;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Label label_xampp;
		private System.Windows.Forms.Label label_project;
		private System.Windows.Forms.Label status_host;
		private System.Windows.Forms.Label status_project;
		private System.Windows.Forms.Label status_xampp;
		private System.Windows.Forms.Label status_win;
		private System.Windows.Forms.Label label_win;
		private System.Windows.Forms.Button default_win;
		private System.Windows.Forms.Button pick_win;
	}
}

