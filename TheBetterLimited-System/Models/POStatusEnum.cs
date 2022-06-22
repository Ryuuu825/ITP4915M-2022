﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    public enum POStatus
    {
        Pending,
        PendingApproval,
        Approved,
        Rejected,
        Cancelled,
        SentToSupplier,
        Inbound,
        Completed
    }
}