using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CAAB.Workers.DTOs;

namespace CAAB.Workers.BackgroundWorkers
{
    public class ResearchFolderForCopying : BackgroundWorker
    {
        public ResearchFolderForCopying()
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = false;
            DoWork += ResearchFolder;
        }

        private void ResearchFolder(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var worker = (BackgroundWorker)sender;
            var result = new ResearchFolderResultsDTO();

            var dto = doWorkEventArgs.Argument as ResearchFolderDTO;
            if (dto == null)
            {
                doWorkEventArgs.Result = result;
                return;
            }


            result.NumberOfDirectories = 0;
            result.NumberOfFiles = 0;

            IEnumerable<string> dirs = Directory.EnumerateDirectories(dto.SourceFolder, "*", SearchOption.AllDirectories);

            try
            {
                foreach (var dir in dirs)
                {
                    result.NumberOfDirectories++;


                    var files = Directory.EnumerateFiles(dir, "*", SearchOption.TopDirectoryOnly);

                    result.NumberOfFiles++;

                    foreach (var file in files)
                    {
                        worker.ReportProgress(1);

                        var fi = new FileInfo(file);
                        result.TotalNumberOfBytes += fi.Length;
                        result.FilesToCopy.Add(file);
                    }
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                // ignore exception
            }

            doWorkEventArgs.Result = result;
        }
    }
}