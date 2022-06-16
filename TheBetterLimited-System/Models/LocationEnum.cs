using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal enum LocationEnum
    {
        [Description("Kolwoon Warehouse")]
        KolwoonWarehouse = 001,
        [Description("TW Main Store")]
        H01,
        [Description("KB Store")]
        H02
    }
}
