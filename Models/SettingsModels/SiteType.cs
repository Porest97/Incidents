using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.SettingsModels
{
    public class SiteType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string SiteTypeName { get; set; }
    }
}
