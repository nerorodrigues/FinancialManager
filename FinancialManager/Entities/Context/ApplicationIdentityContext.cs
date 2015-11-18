using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.Entities.Context
{
    public class ApplicationIdentityContext : IdentityDbContext
    {
        public ApplicationIdentityContext(String pConnectionString)
            :base(pConnectionString)
        {

        }
    }
}
