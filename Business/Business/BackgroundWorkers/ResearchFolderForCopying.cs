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
            var worker = (BackgroundWorker) sender;
            var result = new ResearchFolderResultsDTO();

            var dto = doWorkEventArgs.Argument as ResearchFolderDTO;
            if (dto == null)
            {
                doWorkEventArgs.Result = result;
                return;
            }

            IEnumerable<string> dirs = Directory.EnumerateDirectories(dto.SourceFolder, "*", SearchOption.AllDirectories);
            List<string> files = Directory.EnumerateFiles(dto.SourceFolder, "*", SearchOption.AllDirectories).ToList();

            result.NumberOfDirectories = dirs.Count();
            result.NumberOfFiles = files.Count();

            for (int i = 0; i < result.NumberOfFiles; i++)
            {
                var progress = (int) ((i*100.0)/result.NumberOfFiles);
                worker.ReportProgress(progress);

                var fi = new FileInfo(files[i]);
                result.TotalNumberOfBytes += fi.Length;
            }


            doWorkEventArgs.Result = result;
        }
    }
}