using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.BackgroundWorkers;
using CAAB.Properties;

namespace CAAB
{
    public partial class CAAB : Form
    {
        public ApplicationSettings AppSettings { get; set; }
        public Business.BackgroundWorkers.CopyFilesWorker CopyFilesBackgroundWorker { get; set; }
        public Business.BackgroundWorkers.ResearchFolderForCopying ResearchFolderBackgroundWorker { get; set; }

        public CAAB()
        {
            InitializeComponent();
            AppSettings = ApplicationSettings.Instance;
            CopyFilesBackgroundWorker = new Business.BackgroundWorkers.CopyFilesWorker();
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

            CopyFilesBackgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
            CopyFilesBackgroundWorker.RunWorkerCompleted += BackgroundCopyWorkerOnRunWorkerCompleted;

            var dto = new Business.DTOs.CopyWorkerDTO()
                          {
                              DestinationFolder = AppSettings.DestinationFolderLocation,
                              SourceFolder = AppSettings.SourceFolderLocation
                          };
            CopyFilesBackgroundWorker.RunWorkerAsync(dto);
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

        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            StatusProgressBar.Value = progressChangedEventArgs.ProgressPercentage;
        }

        private void SelectSourceButtonClick(object sender, EventArgs e)
        {
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                SourceFolderLabel.Text = FolderDialog.SelectedPath;
                AppSettings.SourceFolderLocation = FolderDialog.SelectedPath;
                ResearchFolderBackgroundWorker = new ResearchFolderForCopying();
                ResearchFolderBackgroundWorker.ProgressChanged += BackgroundWorkerOnProgressChanged;
                ResearchFolderBackgroundWorker.RunWorkerCompleted += ResearchFolderBackgroundWorkerOnRunWorkerCompleted;

                StatusProgressBar.Value = 0;
                StatusProgressBar.Visible = true;

                ResearchFolderBackgroundWorker.RunWorkerAsync(new Business.DTOs.ResearchFolderDTO { SourceFolder = FolderDialog.SelectedPath });
            }
        }

        private void ResearchFolderBackgroundWorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            if (!runWorkerCompletedEventArgs.Cancelled)
            {
                var resultDTO = runWorkerCompletedEventArgs.Result as Business.DTOs.ResearchFolderResultsDTO;

                FolderCountLabel.Text = String.Format("{0}", resultDTO.NumberOfDirectories);
                FileCountLabel.Text = String.Format("{0}", resultDTO.NumberOfFiles);
                TotalMBLabel.Text = String.Format("{0:#,###,##0.00} MB",
                                                  ((double) (resultDTO.TotalNumberOfBytes/1024.0/1024.0)));
                FolderDetailsPanel.Visible = true;
            }
            WorkingStatusLabel.Visible = false;
            StatusProgressBar.Visible = false;



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
