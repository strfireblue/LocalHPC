using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalHpcShared.Tasks
{
    public class HpcTask
	{

        public int ID { get; set; }

        public int JobID { get; set; }

        public string Name { get; set; }

		// TODO: Probably enum
        public string Type { get; set; }


		// TODO: Undecided, probably need a custom class
        public string ExecutionCommand { get; set; }


		// TODO: Undecided how to handle.  Maybe only uses Task Type
        public string ExecutionClass { get; set; }

        public DateTime TimeStarted { get; set; }

        public DateTime TimeStopped { get; set; }

        //public List<Node> NodesUsed { get; set; }

        public string Status { get; set; }



    }
}
