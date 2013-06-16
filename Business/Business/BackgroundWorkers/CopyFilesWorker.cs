using System;
using System.Collections.Generic;
using System.IO;
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
            var worker = (BackgroundWorker)sender;
            var copyDto = doWorkEventArgs.Argument as Business.DTOs.CopyWorkerDTO;

            var targetFolder = System.IO.Path.Combine(copyDto.DestinationFolder,
                                                      String.Format("{0:yyyy-MM-dd-HH-mm-ss}", copyDto.CreateDate));

            if(!System.IO.Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            var totalFiles = Directory.EnumerateFiles(copyDto.SourceFolder, "*", SearchOption.AllDirectories).Count();

            var dirs = System.IO.Directory.EnumerateDirectories(copyDto.SourceFolder, "*", SearchOption.AllDirectories).ToList();
            dirs.Add(copyDto.SourceFolder);

            var kounter = 1;
            foreach (var dir in dirs)
            {
                var files = System.IO.Directory.EnumerateFiles(dir, "*", SearchOption.TopDirectoryOnly).ToList();

                foreach (var file in files)
                {
                    worker.ReportProgress( (kounter*100/totalFiles));
                    var fi = new System.IO.FileInfo(file);
                    var extraPath = dir.Substring(copyDto.SourceFolder.LastIndexOf("\\"));
                    string targetFileName;
                    string destinationFolder = string.Empty;

                    if( !String.IsNullOrEmpty(extraPath) && !targetFolder.Contains(extraPath))
                    {
                        destinationFolder = System.IO.Path.Combine(targetFolder, extraPath.TrimStart("\\".ToCharArray()));
                    }else
                    {
                        destinationFolder = targetFolder;
                    }

                    targetFileName = Path.Combine(destinationFolder, fi.Name);

                    if (worker.CancellationPending)
                    {
                        break;
                    }
                    if(! Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }
                    System.IO.File.Copy(file, targetFileName);
                    kounter++;
                }
                if( worker.CancellationPending)
                {
                    break;
                }
            }

            if (worker.CancellationPending)
            {
                doWorkEventArgs.Result = "Cancelled";
            }
            else
            {
                doWorkEventArgs.Result = String.Format("Copied {0} files", totalFiles);
            }

        }

    }
}
