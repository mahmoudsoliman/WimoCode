using System;
using System.Collections.Generic;
using System.Text;

namespace Wimo.Data.Entities
{
    public class Task
    {
        public long TaskId { get; set; }
        public string TaskKey { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public string DriverName { get; set; }
        public string Courier { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string DriverComment { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
