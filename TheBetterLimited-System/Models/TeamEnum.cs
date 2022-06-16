using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal enum TeamEnum
    {
        [Description("Delivery T1")]
        DeliveryT1 = 301,
        [Description("Delivery T2")]
        DeliveryT2 = 302,
        [Description("Delivery T3")]
        DeliveryT3 = 303,
        [Description("Delivery T4")]
        DeliveryT4 = 304,
        [Description("Delivery T5")]
        DeliveryT5 = 305,
        [Description("Installation T1")]
        InstallationT1 = 701,
        [Description("Installation T2")]
        InstallationT2 = 702,
        [Description("Installation T3")]
        InstallationT3 = 703,
        [Description("Installation T4")]
        InstallationT4 = 704,
        [Description("Installation T5")]
        InstallationT5 = 705,
    }
}
