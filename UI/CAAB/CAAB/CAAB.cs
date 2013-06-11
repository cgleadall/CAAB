using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAAB.Properties;

namespace CAAB
{
    public partial class CAAB : Form
    {
        public ApplicationSettings AppSettings { get; set; }
        public CAAB()
        {
            InitializeComponent();
            AppSettings = ApplicationSettings.Instance;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            UpdateLastCopyOnScreen();
        }

        private void UpdateLastCopyOnScreen()
        {
            var value = AppSettings.LastCopy;
            if (value > DateTime.MinValue)
            {
                LastCopyStatusLabel.Text = String.Format("Last Copy: {0:yyyy-MM-dd HH:mm:ss}", value);
            }
            else
            {
                LastCopyStatusLabel.Text = String.Format("Last Copy: ");
            }

            SourceFolderLabel.Text = AppSettings.SourceFolderLocation;
            DestinationFolderLabel.Text = AppSettings.DestinationFolderLocation;
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            AppSettings.SaveSettings();
            Close();
        }

        private void BeginCopyClick(object sender, EventArgs e)
        {
            AppSettings.LastCopy = DateTime.Now;
            UpdateLastCopyOnScreen();
            WorkingStatusLabel.Visible = true;
            StatusProgressBar.Visible = true;
            StatusProgressBar.Value = 0;

            BackgroundCopyWorker.WorkerReportsProgress = true;
            BackgroundCopyWorker.WorkerSupportsCancellation = true;
            BackgroundCopyWorker.ProgressChanged += BackgroundCopyWorkerOnProgressChanged;
            BackgroundCopyWorker.DoWork += BackgroundCopyWorkerOnDoWork;
            BackgroundCopyWorker.RunWorkerCompleted += BackgroundCopyWorkerOnRunWorkerCompleted;

            var dto = new Business.DTOs.CopyWorkerDTO()
                          {
                              DestinationFolder = AppSettings.DestinationFolderLocation,
                              SourceFolder = AppSettings.SourceFolderLocation
                          };
            BackgroundCopyWorker.RunWorkerAsync(dto);
        }

        private void BackgroundCopyWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            if (!runWorkerCompletedEventArgs.Cancelled)
            {
                WorkingStatusLabel.Text = runWorkerCompletedEventArgs.Result as String;
            }
            else
            {
                WorkingStatusLabel.Visible = false;
            }
            StatusProgressBar.Visible = false;
            //StatusProgressBar.Value = 0;

        }

        private void BackgroundCopyWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var numberOfFiles = 100;
            var worker = (BackgroundWorker) sender;
            var copyDto = doWorkEventArgs.Argument as Business.DTOs.CopyWorkerDTO;

            for (int i = 0; i < numberOfFiles; i++)
            {
                System.Threading.Thread.Sleep(100);
                if ( worker.CancellationPending)
                {
                    break;
                }
                worker.ReportProgress(i);
            }
            if( worker.CancellationPending)
            {
                doWorkEventArgs.Result = "Cancelled";
            }else
            {
                doWorkEventArgs.Result = String.Format("Copied {0} files", numberOfFiles);
            }

        }

        private void BackgroundCopyWorkerOnProgressChanged(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            StatusProgressBar.Value = progressChangedEventArgs.ProgressPercentage;
        }

        private void SelectSourceButtonClick(object sender, EventArgs e)
        {
            if( FolderDialog.ShowDialog() == DialogResult.OK )
            {
                SourceFolderLabel.Text = FolderDialog.SelectedPath;
                AppSettings.SourceFolderLocation = FolderDialog.SelectedPath;
            }
        }

        private void SelectDestinationButtonClick(object sender, EventArgs e)
        {
            FolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                DestinationFolderLabel.Text = FolderDialog.SelectedPath;
                AppSettings.DestinationFolderLocation = FolderDialog.SelectedPath;
            }

        }
    }
}
