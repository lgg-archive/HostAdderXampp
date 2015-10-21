using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
  @TODO:
 *		add nosound mode
		Try WPF
 */

namespace HostAdderXampp
{
	internal partial class main : Form
	{
		internal string path_xampp, path_xconf, path_project, path_hosts, hostname, checking;
		internal string path_win = @"D:\";

		internal bool ok_host = false, ok_xampp = false, ok_win = false, ok_project = false;

		internal main()
		{
			InitializeComponent();
			//updateAll(); //@TODO: remove this in future
			status_host.ForeColor = System.Drawing.Color.Red;
			status_xampp.ForeColor = System.Drawing.Color.Red;
			status_win.ForeColor = System.Drawing.Color.Red;
			status_project.ForeColor = System.Drawing.Color.Red;
		}

		private void main_Click(object sender, EventArgs e)
		{
			this.ActiveControl = null;
		}

		//HOST
		private void input_host_Leave(object sender, EventArgs e)
		{
			updateHost();
		}

		private void updateHost()
		{
			if (String.IsNullOrEmpty(input_host.Text))
			{
				ok_host = false;
				status_host.ForeColor = System.Drawing.Color.Red;
			}
			else
			{
				hostname = input_host.Text;
				ok_host = true;
				status_host.ForeColor = System.Drawing.Color.Green;
			}
			updateProgress();
		}

		//XAMPP
		private void default_xampp_Click(object sender, EventArgs e)
		{
			path_xampp = @"C:\xampp";
			updateXampp();
		}
		 
		private void updateXampp()
		{
			try
			{
				//Checking is xampp path ok
				checking = Path.GetFullPath(path_xampp);
				if (!File.Exists(path_xampp + @"\apache\conf\httpd.conf"))
				{
					throw new Errors("File path error", "1");
				}
				FileStream fs = new FileStream (path_xampp + @"\apache\conf\httpd.conf", FileMode.OpenOrCreate, FileAccess.Write);
				if (!fs.CanWrite)
				{
					throw new Errors("File locked. Try to run program as Administrator or check if other programs are using this file.", "2");
				}
				fs.Close();
            
				//Logging results
				ok_xampp = true;
				path_xconf = path_xampp + @"\apache\conf\httpd.conf";
				label_xampp.Text = path_xampp;
				status_xampp.ForeColor = System.Drawing.Color.Green;
				result_path_choosen("xampp");
			}
			catch(Errors exc)
			{
				ok_xampp = false;

				status_xampp.ForeColor = System.Drawing.Color.Red;
				if(exc.ErrorCode == "1"){
					label_xampp.Text = "httpd.conf not found!";
					result_wrong_path();
				}
				else
				{
					label_xampp.Text = "httpd.conf locked!";
					result_file_locked();
				}
			}
			catch (Exception exc)
			{
				ok_xampp = false;
				status_xampp.ForeColor = System.Drawing.Color.Red;
			}
			updateProgress();
		}

		private void pick_xampp_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				path_xampp = folderBrowserDialog.SelectedPath;
				updateXampp();
			}
		}

		//PROJECT
		private void updateProject()
		{
			try
			{
				//Checking
				checking = Path.GetFullPath(path_project);

				//Logging results
				ok_project = true;
				label_project.Text = path_project;
				status_project.ForeColor = System.Drawing.Color.Green;
				result_path_choosen("проекта");
			}
			catch
			{
				ok_project = false;
				status_project.ForeColor = System.Drawing.Color.Red;
				result_wrong_path();
			}
			updateProgress();
		}

		private void pick_project_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				path_project = folderBrowserDialog.SelectedPath;
				updateProject();
			}
		}

		//WIN
		private void default_win_Click(object sender, EventArgs e)
		{
			path_win = @"C:\";
			updateWin();
		}

		private void updateWin()
		{
			try
			{
				//Checking is win path ok
				checking = Path.GetFullPath(path_win);
				if (!File.Exists(path_win + @"Windows\System32\drivers\etc\hosts"))
				{
					throw new Errors("File path error", "1");
				}
				FileStream fs = new FileStream(path_win + @"Windows\System32\drivers\etc\hosts", FileMode.OpenOrCreate, FileAccess.Write);
				if (!fs.CanWrite)
				{
					throw new Errors("File locked. Try to run program as Administrator or check if other programs are using this file.", "2");
				}
				fs.Close();

				//Logging results
				ok_win = true;
				path_hosts = path_win + @"Windows\System32\drivers\etc\hosts";
				label_win.Text = path_win;
				status_win.ForeColor = System.Drawing.Color.Green;
				result_path_choosen("до windows");
			}
			catch(Errors exc)
			{
				ok_win = false;

				status_win.ForeColor = System.Drawing.Color.Red;
				if (exc.ErrorCode == "1")
				{
					label_win.Text = "hosts not found!";
					result_wrong_path();
				}
				else
				{
					label_win.Text = "hosts locked!";
					result_file_locked();
				}
			}
			catch (Exception exc)
			{
				ok_xampp = false;
				status_win.ForeColor = System.Drawing.Color.Red;
			}
			updateProgress();
		}

		private void pick_win_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				path_win = folderBrowserDialog.SelectedPath;
				updateWin();
			}
		}

		//Update
		private void updateAll()
		{
			updateXampp();
			updateProject();
			updateHost();
			updateWin();
			updateProgress();
		}

		//Is everything ok:
		private void updateProgress()
		{
			if (ok_host && ok_project && ok_win && ok_xampp)
			{
				add.Enabled = true;
				delete.Enabled = true;
			}else{
				if (ok_host && ok_win && ok_xampp)
				{
					add.Enabled = false;
					delete.Enabled = true;
				}
				else
				{
					add.Enabled = false;
					delete.Enabled = false;
				}
			}
		}

		//ADD & DELETE
		private void add_Click(object sender, EventArgs e)
		{
			try
			{
				//Writing to Host
				StreamWriter streamHosts = new StreamWriter(path_hosts, true);
				streamHosts.WriteLine("127.0.0.1 " + hostname);
				streamHosts.Close();

				//Writing to xampp conf
				string hosttext = "<VirtualHost *:80>" + Environment.NewLine +
								"	DocumentRoot \"" + path_project + "\"" + Environment.NewLine +
								"	ServerName \"" + hostname + "\"" + Environment.NewLine +
								"	ServerAlias \"www." + hostname + "\"" + Environment.NewLine +
								"	<Directory />" + Environment.NewLine +
								"		AllowOverride All" + Environment.NewLine +
								"		Require all granted" + Environment.NewLine +
								"	</Directory>" + Environment.NewLine +
							"</VirtualHost>";

				StreamWriter streamxampp = new StreamWriter(path_xconf, true);
				streamxampp.WriteLine("#" + hostname + "-Start");
				streamxampp.WriteLine(hosttext);
				streamxampp.WriteLine("#" + hostname + "-End");
				streamxampp.Close();

				//Show result
				result_done_add();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message.ToString());
				result_fail();
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			try
			{
				//REGEX
				string reg_rule = @"#" + hostname + "-Start(.*)#" + hostname + "-End";
				Regex myreg = new Regex(reg_rule, RegexOptions.IgnoreCase | RegexOptions.Singleline);

				string host_rule = @"127.0.0.1 " + hostname;
				Regex myhreg = new Regex(host_rule, RegexOptions.IgnoreCase);

				//Clear Hosts
				string before_file = File.ReadAllText(path_hosts);
				string clear_file = myhreg.Replace(before_file, "");
				File.WriteAllText(path_hosts, clear_file);

				//Clear conf
				before_file = File.ReadAllText(path_xconf);
				clear_file = myreg.Replace(before_file, "");
				File.WriteAllText(path_xconf, clear_file);

				//Result
				result_done_delete();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message.ToString());
				result_fail();
			}
		}

		//Results
		private void result_done_delete()
		{
			result.ForeColor = System.Drawing.Color.Green;
			result.Text = "Удалили! Не забудьте перезапустить Apache!";
			result_sound(true);

		}

		private void result_done_add()
		{
			result.ForeColor = System.Drawing.Color.Green;
			result.Text = "Добавили! Не забудьте перезапустить Apache!";
			result_sound(true);
		}

		private void result_fail()
		{
			result.ForeColor = System.Drawing.Color.Red;
			result.Text = "Неуспешно, произошла ошибка!";
			result_sound(false);
		}

		private void result_path_choosen(string target)
		{
			result.ForeColor = System.Drawing.Color.Green;
			result.Text = "Путь " + target + " выбран";
			result_sound(true);
		}

		private void result_wrong_path(){
			result.ForeColor = System.Drawing.Color.Red;
			result.Text = "Неверный путь!";
			result_sound(false);
		}

		private void result_file_locked()
		{
			result.ForeColor = System.Drawing.Color.Red;
			result.Text = "Some file locked";
			MessageBox.Show("File locked. Try to run program as Administrator or check if other programs are using this file.");
			result_sound(false);
		}

		private void result_sound(bool success)
		{
			if (success)
			{
				System.Media.SystemSounds.Asterisk.Play();
			}
			else
			{
				System.Media.SystemSounds.Hand.Play();
			}
		}

		//debug
		private void l(string msg)
		{
			MessageBox.Show(msg);
		}
	}

	internal class Errors : System.Exception
	{
		/*
			 1 - Wrong path
			 2 - File isn't writable
		 */
		public String ErrorCode = "";

		public Errors()
			: base()
		{
		}

		public Errors(string message, string code)
			: base(message)
		{
			this.ErrorCode = code;
		}

		public Errors(string message, Exception inner, string code)
			: base(message, inner)
		{
			this.ErrorCode = code;
		}
	}
}
