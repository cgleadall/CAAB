using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CAAB.Workers.DTOs;

namespace CAAB.Workers.BackgroundWorkers
{
    public class CopyFilesWorker : BackgroundWorker
    {
        public CopyFilesWorker()
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
            DoWork += CopyFilesWorkerOnDoWork;
        }

        private void CopyFilesWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var worker = (BackgroundWorker) sender;
            var copyDto = doWorkEventArgs.Argument as CopyWorkerDTO;
            var resultDTO = new CopyWorkerResultsDTO();

            string targetFolder = Path.Combine(copyDto.DestinationFolder,
                                               String.Format("{0:yyyy-MM-dd-HH-mm-ss}", copyDto.CreateDate));

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            resultDTO.TotalFiles = copyDto.FilesToCopy.Count;
            resultDTO.TotalBytes = 0;

            int kounter = 1;
            Stopwatch sw = Stopwatch.StartNew();
                foreach (string file in copyDto.FilesToCopy)
                {
                    worker.ReportProgress((kounter*100/resultDTO.TotalFiles));
                    var fi = new FileInfo(file);

                    resultDTO.TotalBytes += fi.Length;

                    string extraPath = fi.DirectoryName.Substring(copyDto.SourceFolder.LastIndexOf("\\"));
                    string targetFileName;
                    string destinationFolder = string.Empty;

                    if (!String.IsNullOrEmpty(extraPath) && !targetFolder.Contains(extraPath))
                    {
                        destinationFolder = Path.Combine(targetFolder, extraPath.TrimStart("\\".ToCharArray()));
                    }
                    else
                    {
                        destinationFolder = targetFolder;
                    }

                    targetFileName = Path.Combine(destinationFolder, fi.Name);

                    if (worker.CancellationPending)
                    {
                        break;
                    }
                    if (! Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }
                    File.Copy(file, targetFileName);
                    kounter++;

                    if (worker.CancellationPending)
                {
                    break;
                }
            }
            sw.Stop();
            resultDTO.TotalMilliseconds = sw.ElapsedMilliseconds;

            if (worker.CancellationPending)
            {
                resultDTO.Message = "Cancelled";
            }
            else
            {
                resultDTO.Message = String.Format("Copied {0} files", resultDTO.TotalFiles);
            }

            doWorkEventArgs.Result = resultDTO;
        }
    }
}