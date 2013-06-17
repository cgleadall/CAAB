using System;

namespace CAAB.Workers.DTOs
{
    public class CopyWorkerDTO
    {
        public DateTime CreateDate { get; set; }
        public string SourceFolder { get; set;}
        public string DestinationFolder { get; set; }
    }
}
