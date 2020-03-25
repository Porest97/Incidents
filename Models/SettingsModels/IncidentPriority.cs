using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.SettingsModels
{
    public class IncidentPriority
    {
        public int Id { get; set; }

        [Display(Name ="Prio.")]
        public string IncidentPriorityName { get; set; }
    }
}
