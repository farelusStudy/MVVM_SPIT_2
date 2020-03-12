using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_SPIT.Models
{
    class ResultContext : DbContext
    {
        public DbSet<RequestResult> RequestResults { get; set; }
    }
}
