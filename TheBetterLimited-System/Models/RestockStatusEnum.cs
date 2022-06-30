using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal enum RestockStatusEnum
    {
        Pending,
        PendingApproval,
        Approved,
        Rejected,
        Handling,
        Completed
    }
}
