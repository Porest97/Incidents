using Incidents.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.ViewModels
{
    public class POsViewModel
    {
        public List<PurchaseOrder> PurchaseOrders { get; internal set; }
    }
}
