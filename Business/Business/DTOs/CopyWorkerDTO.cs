using System;
using System.Collections.Generic;

namespace CAAB.Workers.DTOs
{
    public class CopyWorkerDTO
    {
        public DateTime CreateDate { get; set; }
        public string SourceFolder { get; set;}
        public string DestinationFolder { get; set; }

        public List<string> FilesToCopy { get; set; }

        public CopyWorkerDTO()
        {
            FilesToCopy = new List<string>();
        }
    }
}
