using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.SettingsModels
{
    public class IncidentReportStatus
    {
        public int Id { get; set; }

        [Display(Name="Status")]
        public string IncidentReportStatusName { get; set; }
    }
}
