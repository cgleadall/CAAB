using System.ComponentModel;
using System.IO;
using System.Linq;

namespace Business.BackgroundWorkers
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
            var result = new DTOs.ResearchFolderResultsDTO();

            var dto = doWorkEventArgs.Argument as DTOs.ResearchFolderDTO;
            if( dto == null)
            {
                doWorkEventArgs.Result = result;
                return;
            }

            var dirs = System.IO.Directory.EnumerateDirectories(dto.SourceFolder, "*", SearchOption.AllDirectories);
            var files = System.IO.Directory.EnumerateFiles(dto.SourceFolder, "*", SearchOption.AllDirectories).ToList();

            result.NumberOfDirectories = dirs.Count();
            result.NumberOfFiles = files.Count();

            for (int i = 0; i < result.NumberOfFiles; i++)
            {
                var progress = (int)((i * 100.0) / result.NumberOfFiles);
                worker.ReportProgress(progress);
              
                var fi = new FileInfo(files[i]);
                result.TotalNumberOfBytes += fi.Length;
            }


            doWorkEventArgs.Result = result;

        }
    }
}