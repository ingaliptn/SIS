using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using TaskScheduler;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            UpdateGlobalProgramRun();
            UpdateLocalUserProgram();
            UpdateSheduleTask();
            UpdateCurrentTask();
           
        }

        private void UpdateGlobalProgramRun()
        {
            GlobalProgramRun.Clear();
            var services = Registry.LocalMachine
                .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run")
                .GetValueNames()
                .ToList();
            services.ForEach(s => GlobalProgramRun.AppendText(s + Environment.NewLine));
        }

        private void UpdateLocalUserProgram()
        {
            LocalUserProgram.Clear();
            var services = Registry.CurrentUser
                .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run")
                .GetValueNames()
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList();
            services.ForEach(s => LocalUserProgram.AppendText(s + Environment.NewLine));
        }

        private void UpdateSheduleTask()
        {
            SheduleTask.Clear();
            ParseScheduleTasks().ToList().ForEach(s => SheduleTask.AppendText(s + Environment.NewLine));
        }

        private IList<string> ProcessTaskFolder(ITaskFolder tFolder, string author = "")
        {
            var scheduledTasks = new List<string>();
            var tCol = tFolder.GetTasks((int)_TASK_ENUM_FLAGS.TASK_ENUM_HIDDEN);

            for (int idx = 1; idx <= tCol.Count; idx++)
            {
                if (string.IsNullOrEmpty(author))
                    scheduledTasks.Add(tCol[idx].Name);

                var principal = GetAuthorFromXmlString(tCol[idx].Xml);
                if (!string.IsNullOrEmpty(principal) && principal == author)
                    scheduledTasks.Add(tCol[idx].Name);
            }

            var tFolderCol = tFolder.GetFolders(0);
            for (int idx = 1; idx <= tFolderCol.Count; idx++)
                ProcessTaskFolder(tFolderCol[idx]);

            return scheduledTasks;
        }

        private string GetAuthorFromXmlString(string xmlString)
        {
            if (string.IsNullOrEmpty(xmlString))
                return string.Empty;

            var xml = new XmlDocument();
            xml.LoadXml(xmlString);
            var registrationInfo = xml.GetElementsByTagName("RegistrationInfo");
            var childNodes = registrationInfo[0].ChildNodes;
            if (registrationInfo.Count == 0 || childNodes.Count == 0)
                return string.Empty;

            var authorNode = string.Empty;
            foreach (XmlNode node in childNodes)
                if (node.Name == "Author")
                    authorNode = node.InnerText;

            return authorNode;
        }
        
        private IList<string> ParseScheduleTasks(bool forCurrentUser = false)
        {
            var TaskServ = new TaskScheduler.TaskScheduler();
            TaskServ.Connect();

            if (!forCurrentUser)
                return ProcessTaskFolder(TaskServ.GetFolder("\\"));

            var author = string.Join("\\", GetAuthorName(TaskServ));
            return ProcessTaskFolder(TaskServ.GetFolder("\\"), author);
        }

        private IEnumerable<string> GetAuthorName(TaskScheduler.TaskScheduler TaskServ)
        {
            if (TaskServ != null)
            {
                if (!string.IsNullOrEmpty(TaskServ.ConnectedDomain))
                    yield return TaskServ.ConnectedDomain;

                if (!string.IsNullOrEmpty(TaskServ.ConnectedUser))
                    yield return TaskServ.ConnectedUser;
            }
        }
        
        private void UpdateCurrentTask()
        {
            CurrentTask.Clear();
            ParseScheduleTasks(true).ToList().ForEach(s => CurrentTask.AppendText(s + Environment.NewLine));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            UpdateGlobalProgramRun();
            UpdateLocalUserProgram();
            UpdateSheduleTask();
            UpdateCurrentTask();
        }

        private void buttonAddToAutoStart_Click(object sender, EventArgs e)
        {
            string ExePath = AutostartProgram.Text.ToString();
            RegistryKey reg;
            reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            try
            {
                if(checkBox1.Checked)
                {
                    reg.DeleteValue(ExePath);
                }   
                else
                {
                    reg.SetValue(ExePath, "\"" + ExePath + "\"");
                }
                reg.Flush();
                reg.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Сould not add program to autostart");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ExportKey(string key, string path)
        {
            string arguments = $"reg export \"{key}\" \"{path}\" /y";
            string strCmdText = "/C " + arguments;
            const string FILE_NAME = "cmd.exe";

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = FILE_NAME,
                    Arguments = strCmdText,
                    UseShellExecute = false,
                    CreateNoWindow = false,
                }
            };

            try
            {
                process.Start();
                if (process != null)
                    process.WaitForExit();
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to copy partition");
            }
            
        }

        private void buttonCopy_Click_1(object sender, EventArgs e)
        {
            string key = RegisterSection.Text;
            var path = $@"{Environment.CurrentDirectory}\exported-{key}.reg";

            ExportKey(key, path);
            string PathToFile = path.ToString();
            MessageBox.Show($"Copy complete \n Path to file: {PathToFile}");

            RegisterSection.Text = string.Empty;
        }

        private void buttonAddToAssociation_Click(object sender, EventArgs e)
        {
            var path = $@"{Environment.CurrentDirectory}\tttAssociation.reg";
            string arguments = $"/s {path}";
            var regProcess = Process.Start($"regedit.exe", arguments);
            regProcess.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxCurrentUserPrograms_TextChanged(object sender, EventArgs e)
        {

        }
    }
}