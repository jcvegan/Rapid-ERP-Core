using System;
using System.ComponentModel.DataAnnotations;

namespace Rapid.Data.Model.Logging {
    public class LogEvent {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        
        public string StackTrace { get; set; }
        public DateTime LogDate { get; set; }
    }
}