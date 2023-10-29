using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promee_Prototype2.Model
{
    public class TodoItem
    {
        public string Task { get; set; }
        public string Note { get; set; }
        public DateTime ScheduleDate { get; set; }
        public TimeSpan STime { get; set; }
        public TimeSpan ETime { get; set; }
    }
}
