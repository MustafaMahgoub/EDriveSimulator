using System;

namespace EDriveSimulator.Models
{
    public class DriverTask
    {
        public int TrainNumber { get; set; }
        public string TrainNumberPrefix { get; set; }
        public string TrainNumberSuffix { get; set; }
        public DateTimeOffset? BeginHour { get; set; }
        public DateTimeOffset? EndHour { get; set; }
        public DateTimeOffset? SortingHour { get; set; }
        public string PhoneNumber { get; set; }
        public string Mission { get; set; }
        public string PerformanceNumber { get; set; }
        public string Depot { get; set; }
        public string Status { get; set; }
        public string IdfNumber { get; set; }
        public string PtcarFrom { get; set; }
        public string PtcarTo { get; set; }
        public string TrainDriverName { get; set; }
    }
}
