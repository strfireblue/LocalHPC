using LocalHpcShared.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalHpcShared.Jobs
{
    public class Job
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        
        // TODO: Maybe this becomes an Enum
        public string Type { get; set; }

        public DateTime SubmissionDateTime { get; set; }

        public string SubmittedBy { get; set; }

        
        // TODO: Probably becomes an Enum
        public string Status { get; set; }


        /// <summary>
        /// The DateTime the Job was completed.  Could be null if the Job doesn't finish.
        /// </summary>
        public DateTime? CompletedDateTime { get; set; }

        //public List<Node> NodesUsed { get; set; }

        public List<HpcTask> Tasks { get; set; }



    }
}
