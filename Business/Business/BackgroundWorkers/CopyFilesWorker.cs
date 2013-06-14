using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Business.BackgroundWorkers
{
    public class CopyFilesWorker : BackgroundWorker
    {
        public CopyFilesWorker()
        {
            this.WorkerReportsProgress = true;
            this.WorkerSupportsCancellation = true;
            this.DoWork += CopyFilesWorkerOnDoWork;

        }

        private void CopyFilesWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var numberOfFiles = 100;
            var worker = (BackgroundWorker)sender;
            var copyDto = doWorkEventArgs.Argument as Business.DTOs.CopyWorkerDTO;

            for (int i = 0; i < numberOfFiles; i++)
            {
                System.Threading.Thread.Sleep(100);
                if (worker.CancellationPending)
                {
                    break;
                }
                worker.ReportProgress(i);
            }
            if (worker.CancellationPending)
            {
                doWorkEventArgs.Result = "Cancelled";
            }
            else
            {
                doWorkEventArgs.Result = String.Format("Copied {0} files", numberOfFiles);
            }

        }

    }
}
