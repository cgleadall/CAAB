namespace CAAB.Workers.DTOs
{
    public class CopyWorkerResultsDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public long TotalBytes { get; set; }
        public long TotalMilliseconds { get; set; }
        public int TotalFiles { get; set; }
    }
}