using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal enum PositionEnum
    {
        Server = 000,
        Admin = 001,
        Salesman = 201,
        [Description("Sales Manager")]
        SalesManager = 202,
        [Description("Inventory Clerk")]
        InventoryClerk = 301,
        [Description("Inventory Manager")]
        InventoryManager = 302,
        [Description("Delivery Workman")]
        DeliveryWorkman = 303,
        Accountant = 401,
        [Description("Accountant Manager")]
        AccountantManager = 402,
        [Description("IT Staff")]
        ITStaff = 601,
        [Description("IT Manager")]
        ITManager = 602,
        [Description("Technical Workman")]
        TechnicalWorkman = 701,
        [Description("Technical Manager")]
        TechnicalManager = 702,
        [Description("Purchase Clerk")]
        PurchaseClerk = 801,
        [Description("Purchase Manager")]
        PurchaseManager = 802,
        President = 904,
        Freeride = President
    }
}
