using Incidents.Models.SettingsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Incidents.Models.DataModels
{
    public class IncidentReport
    {
        public int Id { get; set; }


        //Status
        [Display(Name = "Status")]
        public int? IncidentReportStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("IncidentReportStatusId")]
        public IncidentReportStatus IncidentReportStatus { get; set; }


        // Incident
        [Display(Name = "Incident")]
        public int? IncidentId { get; set; }
        [Display(Name = "Incident")]
        [ForeignKey("IncidentId")]
        public Incident Incident { get; set; }

        // Conclutions
        [Display(Name = "Conclusions")]
        public string ReportConclusions { get; set; }


        // WorkLogs

        //[Display(Name = "WL #1")]
        //public int? WorkLogId { get; set; }
        //[Display(Name = "WL #1")]
        //[ForeignKey("WorkLogId")]
        //public WorkLog FirstVisit { get; set; }

        //[Display(Name = "WL #2")]
        //public int? WorkLogId1 { get; set; }
        //[Display(Name = "WL #2")]
        //[ForeignKey("WorkLogId1")]
        //public WorkLog SecondVisit { get; set; }

        //[Display(Name = "WL #3")]
        //public int? WorkLogId2 { get; set; }
        //[Display(Name = "WL #3")]
        //[ForeignKey("WorkLogId2")]
        //public WorkLog ThirdVisit { get; set; }

        //[Display(Name = "WL #4")]
        //public int? WorkLogId3 { get; set; }
        //[Display(Name = "WL #4")]
        //[ForeignKey("WorkLogId3")]
        //public WorkLog FourthVisit { get; set; }



    }
}
