using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troublestaller
{
    public partial class TroubleStallerForm : Form
    {
        public TroubleStallerForm()
        {
            InitializeComponent();
        }

        private void WelcomeButton_Click(object sender, EventArgs e)
        {
            this.wizardTabControl.SelectedIndex += 1;
            Log("Welcome page passed");
        }

        private void TroubleStallerForm_Load(object sender, EventArgs e)
        {
            //Hide Tabs
            this.wizardTabControl.ItemSize = new Size(1, 1);
            this.wizardTabControl.SizeMode = TabSizeMode.Fixed;

            //Load the EULA
            LoadEULA();
        }

        private void LoadEULA()
        {
            //Load in the EULA
            if(File.Exists("eula.txt"))
            {
                this.eula.Text = File.ReadAllText("eula.txt");
                Log("EULA Loaded from eula.txt");
            }
        }

        //Install prerequisites
        private void InstallPrerequisites()
        {
            if (Directory.Exists("prerequisites"))
            {
                string[] PreReqFiles = Directory.EnumerateFiles("prerequisites", "*.exe").ToArray(); ;
                if (PreReqFiles.Count() < 1)
                {
                    Log("No EXE's found in prerequisites directory to install");
                }
                else
                {
                    foreach (string file in PreReqFiles)
                    {
                        Process p = new Process();
                        p.StartInfo.Arguments = "/S";
                        p.StartInfo.FileName = file;
                        p.Start();

                        Log("Starting " + file + " prerequisite installer");

                        p.WaitForExit();
                        Log("" + file + " prerequisite installer completed with exit code of " + p.ExitCode.ToString());
                    }
                }
            }
            else
            {
                Log("No prerequisites directory found");
            }
        }

        //Create a log
        private void Log(string Line)
        {
            if(!Program.LogPath.Equals(""))
            {
                try
                {
                    File.AppendAllText(Program.LogPath, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")+" - "+Line);
                }catch(Exception e)
                {

                }
            }
        }

        private void agreeButton_Click(object sender, EventArgs e)
        {
            Log("EULA accepted, starting install");
            wizardTabControl.SelectedIndex += 1;
        }

        private void DisagreeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You must accept the EULA to continue");
        }

        private void InstallingPage_Enter(object sender, EventArgs e)
        {
            this.installingProgress.Maximum = 100;
            InstallPrerequisites();
            this.installingProgress.Value = 30;

            InstallFiles();
            this.installingProgress.Value = 100;
            this.installedButton.Visible = true;
            this.installingLabel.Text = "Installed";
        }

        private void InstallFiles()
        {
            if (Directory.Exists("files"))
            {
                string[] InstallDirectories = Directory.EnumerateDirectories("files").ToArray(); ;
                if (InstallDirectories.Count() < 1)
                {
                    Log("No files found to install");
                }
                else
                {
                    foreach (string directory in InstallDirectories)
                    {
                        string dest = GetLocalDirectory(directory);
                        Log("Installing " + dest + " files");

                        foreach (string file in Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories))
                        {
                            Log("Copying " + file + " to " + file.Replace(directory, dest) + "");
                            File.Copy(file, file.Replace(directory, dest));
                        }
                    }
                }
            }
            else
            {          
                    Log("No files directory found");
            }
        }

        private string GetLocalDirectory(string directory)
        {
            string dir = null;

            string directoryName = new DirectoryInfo(directory).Name;
            switch (directoryName)
            {
                case "UserProfile":
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    break;
                case "AppData":
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    break;
                case "StartMenu":
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                    break;
                case "Desktop":
                    dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    break;
            }


            return dir;
        }

        private void installedButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process openURL = new Process();
            openURL.StartInfo.FileName = "https://github.com/maltobelli/Troublestaller";
            openURL.StartInfo.UseShellExecute = true;
            openURL.Start();
        }
    }
}
