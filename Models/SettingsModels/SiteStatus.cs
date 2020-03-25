using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.SettingsModels
{
    public class SiteStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string SiteStatusName { get; set; }
    }
}
