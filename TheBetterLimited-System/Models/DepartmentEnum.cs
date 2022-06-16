using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal enum DepartmentEnum
    {
        System = 000,
        Admin = 010,
        Sales = 200,
        Inventory = 300,
        Accounting = 400,
        [Description("Information Technology")]
        InformationTechnology = 600,
        Technical = 700,
        Purchase = 800,
        Freeride = 999,
    }
}
