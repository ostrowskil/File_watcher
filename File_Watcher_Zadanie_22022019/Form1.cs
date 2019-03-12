using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace File_Watcher_Zadanie_22022019
{
    public partial class Form1 : Form


    {
        private FileSystemWatcher _monit;

        public Form1()
        {
            
            InitializeComponent();
            InitializeWatcher();
            timer1.Enabled = true;            

        }

        private void InitializeWatcher()
        {
            _monit = new FileSystemWatcher();
            _monit.Changed += _monit_Changed;
            _monit.Created += _monit_Changed;
            _monit.Deleted += _monit_Changed;
            _monit.Renamed += _monit_Changed;
            _monit.Path = tB_PathFolder.Text;
            _monit.EnableRaisingEvents = true;  
        }

        public void _monit_Changed(object sender, FileSystemEventArgs e)
        {

            DateTime time = DateTime.Now;
            string log = "";

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
                    
                    log = $"{time}\r\n Utworzono plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Deleted:
                    log = $"{time}\r\n Skasowano plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Changed:
                    log = $"{time}\r\n Zmieniono plik: {e.FullPath}";
                    break;
                case WatcherChangeTypes.Renamed:
                    log = $"{time}\r\n Zmieniono nazwe pliku: {e.FullPath}";
                    break;
                case WatcherChangeTypes.All:
                    break;
                default:
                    break;
            }

            if (InvokeRequired)     
            {
                BeginInvoke((Action)(() =>
                {
                    listBox1_Logs.Items.Insert(0, log);

                }));
            }

            Task task1 = Task.Run(() => NotificationEmail(e));
            
            
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Czas_Click(object sender, EventArgs e)
        {

        }

        private void label1_ActualTime_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            int H = time.Hour;
            int M = time.Minute;
            int S = time.Second;
            
            this.Text = $"Monitor Folderu {H}:{M}:{S}";

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tB_PathFolder.Text = folderBrowserDialog1.SelectedPath;
                InitializeWatcher();
            }
        }

        private void NotificationEmail(FileSystemEventArgs e)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential()
            {
                UserName = "balluffkurscsharp@gmail.com",
                Password = "0okmNJI("
            };
            client.EnableSsl = true;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("balluffkurscsharp@gmail.comm", "Kurs Programowania");
            message.To.Add(new MailAddress("lukasz.ostrowski@balluff.pl", "Łukasz"));
            message.Subject = "Nastąpiła zmiana w folderze";
            message.Body = $"Uwaga,\r\n nastąpiła zmiana w folderze {tB_PathFolder.Text} na pliku {e.Name} .\r\n ";
                             
            client.SendMailAsync(message);
            
            
        }
        
       

        private void tB_PathFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_Logs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_StatusEmail_Click(object sender, EventArgs e)
        {

        }

        private void tB_StatusEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
