﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.DataModels
{
    public class NABLog
    {
        public int Id { get; set; }

        [Display(Name = "INC #")]
        public int? IncidentId { get; set; }
        [Display(Name = "INC #")]
        [ForeignKey("IncidentId")]
        public Incident Incident { get; set; }

        [Display(Name = "Started")]
        public DateTime DateTimeStarted { get; set; }

        [Display(Name = "Ended")]
        public DateTime DateTimeEnded { get; set; }

        [Display(Name = "Log notes")]
        public string LogNotes { get; set; }

        //Billing !
        [Display(Name = "Hours")]
        public decimal Hours { get; set; }

        [Display(Name = "Price. Hour")]
        public decimal PriceHour { get; set; }

        [Display(Name = "MTR. Cost")]
        public decimal MtrCost { get; set; }

        [Display(Name = "Total")]
        public decimal TotalCost { get; set; }

        //WorkLog in DWorkins system !
        [Display(Name = "WL #")]
        public int? WLogId { get; set; }
        [Display(Name = "WL #")]
        [ForeignKey("WLogId")]
        public WLog WLog { get; set; }



    }
}
