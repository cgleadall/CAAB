using System.Collections.Generic;

namespace CAAB.Workers.DTOs
{
    public class ResearchFolderResultsDTO
    {
        public int NumberOfFiles { get; set; }
        public int NumberOfDirectories { get; set; }
        public long TotalNumberOfBytes { get; set; }

        public List<string> FilesToCopy { get; set; }

        public ResearchFolderResultsDTO()
        {
            FilesToCopy = new List<string>();
        }
    }
}