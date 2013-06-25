using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CAAB.Properties;
using CAAB.Workers.BackgroundWorkers;
using CAAB.Workers.DTOs;

namespace CAAB
{
    public partial class CAAB : Form
    {
        public ApplicationSettings AppSettings { get; set; }
        public CopyFilesWorker CopyFilesBackgroundWorker { get; set; }
        public ResearchFolderForCopying ResearchFolderBackgroundWorker { get; set; }

        public List<string> FilesToCopy { get; set; }
        private bool ShownHasBeenRun { get; set; }
        public CAAB()
        {
            InitializeComponent();
            AppSettings = ApplicationSettings.Instance;
            CopyFilesBackgroundWorker = new CopyFilesWorker();
            ShownHasBeenRun = false;

            FilesToCopy = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);


            UpdateLastCopyOnScreen();

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!ShownHasBeenRun)
            {
                if (!String.IsNullOrEmpty(AppSettings.SourceFolderLocation))
                {
                    StartResearchingSourceFolder(AppSettings.SourceFolderLocation);
                }

                if (!String.IsNullOrEmpty(AppSettings.DestinationFolderLocation))
                {
                    ResearchDestinationFolder(AppSettings.DestinationFolderLocation);
                }
            }
            ShownHasBeenRun = true;
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
            if( FilesToCopy == null)
            {
                MessageBox.Show("No files to copy");
                BeginCopy.Enabled = false;
                return;
            }

            Cursor = Cursors.AppStarting;
            BeginCopy.Enabled = false;
            StopCopyButton.Enabled = true;

            AppSettings.LastCopy = DateTime.Now;
            UpdateLastCopyOnScreen();
            WorkingStatusLabel.Text = "copying...";
            WorkingStatusLabel.Visible = true;

            StatusProgressBar.Style = ProgressBarStyle.Continuous;
            StatusProgressBar.Value = 0;
            StatusProgressBar.Visible = true;

            CopyFilesBackgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            CopyFilesBackgroundWorker.RunWorkerCompleted += BackgroundCopyWorkerOnRunWorkerCompleted;

            var dto = new CopyWorkerDTO()
                          {
                              CreateDate = DateTime.Now,
                              DestinationFolder = AppSettings.DestinationFolderLocation,
                              SourceFolder = AppSettings.SourceFolderLocation
                          };
            dto.FilesToCopy.AddRange(FilesToCopy);
            CopyFilesBackgroundWorker.RunWorkerAsync(dto);
        }

        private void BackgroundCopyWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            var resultDTO = (CopyWorkerResultsDTO)runWorkerCompletedEventArgs.Result;
            if (!runWorkerCompletedEventArgs.Cancelled)
            {
                WorkingStatusLabel.Text = resultDTO.Message;
                UpateStatusBarMetrics(resultDTO);
            }
            else
            {
                WorkingStatusLabel.Visible = false;
            }
            StatusProgressBar.Visible = false;
            BeginCopy.Enabled = true;
            StopCopyButton.Enabled = false;
            Cursor = Cursors.Arrow;
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            StatusProgressBar.Value = progressChangedEventArgs.ProgressPercentage;
        }

        private void SelectSourceButtonClick(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            SelectSourceButton.Enabled = false;
            BeginCopy.Enabled = false;

            FolderDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            
            var dialogResult = FolderDialog.ShowDialog();

            switch (dialogResult)
            {
                case DialogResult.OK:
                    SourceFolderLabel.Text = FolderDialog.SelectedPath;
                    AppSettings.SourceFolderLocation = FolderDialog.SelectedPath;

                    StartResearchingSourceFolder(FolderDialog.SelectedPath);
                    break;
                default:
                    Cursor = Cursors.Arrow;
                    break;
            }
        }

        private void StartResearchingSourceFolder(string selectedPath)
        {
            ResearchFolderBackgroundWorker = new ResearchFolderForCopying();
            ResearchFolderBackgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            ResearchFolderBackgroundWorker.RunWorkerCompleted += ResearchFolderBackgroundWorkerOnRunWorkerCompleted;

            StatusProgressBar.Style = ProgressBarStyle.Marquee;
            StatusProgressBar.Value = 0;
            StatusProgressBar.Visible = true;

            ResearchFolderBackgroundWorker.RunWorkerAsync(new ResearchFolderDTO { SourceFolder = selectedPath });
        }

        private void ResearchFolderBackgroundWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            if (!runWorkerCompletedEventArgs.Cancelled)
            {
                var resultDTO = runWorkerCompletedEventArgs.Result as ResearchFolderResultsDTO;

                FolderCountLabel.Text = String.Format("{0}", resultDTO.NumberOfDirectories);
                FileCountLabel.Text = String.Format("{0}", resultDTO.NumberOfFiles);
                TotalMBLabel.Text = String.Format("{0:#,###,##0.00} MB",
                                                  ((double)(resultDTO.TotalNumberOfBytes / 1024.0 / 1024.0)));
                FolderDetailsPanel.Visible = true;

                FilesToCopy = new List<string>(resultDTO.FilesToCopy.Count());
                FilesToCopy.AddRange(resultDTO.FilesToCopy);
            }
            WorkingStatusLabel.Visible = false;
            StatusProgressBar.Visible = false;


            SelectSourceButton.Enabled = true;
            BeginCopy.Enabled = true;
            Cursor = Cursors.Arrow;
        }

        private void SelectDestinationButtonClick(object sender, EventArgs e)
        {
            Cursor = Cursors.AppStarting;
            BeginCopy.Enabled = false;

            FolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var dialogresult = FolderDialog.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                var selectedPath = FolderDialog.SelectedPath;

                ResearchDestinationFolder(selectedPath);
            }

            BeginCopy.Enabled = true;
            Cursor = Cursors.Arrow;

        }

        private void ResearchDestinationFolder(string selectedPath)
        {
            var drive = new System.IO.DriveInfo(selectedPath.Substring(0, 1));

            bool forceCopy = false;

            if (drive.DriveType != DriveType.Removable)
            {
                var message =
                    String.Format(
                        "The selected path is on drive ({0}) which is not removable.\r\nAre you sure that you want to copy to this location?",
                        drive.Name);
                var dialogResult = MessageBox.Show(message, "Are you sure?", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                forceCopy = dialogResult == DialogResult.Yes;
                if( dialogResult == DialogResult.No)
                {
                    AppSettings.DestinationFolderLocation = String.Empty;
                    DestinationFolderLabel.Text = AppSettings.DestinationFolderLocation;
                }
            }

            if (forceCopy || drive.DriveType == DriveType.Removable)
            {
                DestinationFolderLabel.Text = selectedPath;
                AppSettings.DestinationFolderLocation = selectedPath;


                FreeSpaceLabel.Text = String.Format("{0:#,###,##0.00} MB",
                                                    drive.AvailableFreeSpace / 1024.0 / 1024.0);
                TotalUsedSpaceLabel.Text = String.Format("{0:#,###,##0.00} MB", drive.TotalSize / 1024.0 / 1024.0);
                VolumeNameLabel.Text = String.Format("{0} - {1}", drive.VolumeLabel, drive.Name);

                DriveDetailsPanel.Visible = true;
            }
        }

        private void UpateStatusBarMetrics(CopyWorkerResultsDTO resultsDTO)
        {

            CopyThroughputLabel.Text = String.Format("at {0:#,##0.00} MB/s",
                                                     resultsDTO.TotalBytes / 1024.0 / 1024.0 / (resultsDTO.TotalMilliseconds / 1000.0));
            var dt = new DateTime(2013, 10, 1, 0, 0, 0);
            dt = dt.AddMilliseconds(resultsDTO.TotalMilliseconds);

            TotalCopyTimeLabel.Text = String.Format("in {0:HH:mm:ss}", dt);

            CopyThroughputLabel.Visible = true;
            TotalCopyTimeLabel.Visible = true;
        }

        private void StopCopyButtonClick(object sender, EventArgs e)
        {
            CopyFilesBackgroundWorker.CancelAsync();
        }
    }
}
