using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.DTOs
{
    public class CopyWorkerDTO
    {
        public DateTime CreateDate { get; set; }
        public string SourceFolder { get; set;}
        public string DestinationFolder { get; set; }
    }
}
