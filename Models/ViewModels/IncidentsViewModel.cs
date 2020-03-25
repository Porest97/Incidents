using Incidents.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.ViewModels
{
    public class IncidentsViewModel
    {
        public List<Incident> Incidents { get; internal set; }
    }
}
