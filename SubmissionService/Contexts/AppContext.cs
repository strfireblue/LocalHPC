using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmissionService.Contexts
{
    public class AppContext : DbContext
    {

        IEnumerable<Jobs.Job> Jobs { get; set; }

        IEnumerable<Tasks.HpcTask> HpcTasks { get; set; }



    }
}
