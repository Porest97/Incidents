﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.SettingsModels
{
    public class SiteRole
    {
        public int Id { get; set; }

        [Display(Name = "Role")]
        public string SiteRoleName { get; set; }
    }
}
