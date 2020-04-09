using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.DataModels
{
    public class WLog
    {
        public int Id { get; set; }

        [Display(Name="WL #")]
        public string WLNumber { get; set; }

        [Display(Name = "Hours")]
        public decimal Hours { get; set; }

        [Display(Name = "DateTimeFrom")]
        public DateTime DateTimeFrom { get; set; }

        [Display(Name = "DateTimeTo")]
        public DateTime DateTimeTo { get; set; }

        [Display(Name = "Subject")]
        public string Subject { get; set; }


    }
}
