using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels
{
    public class CompanyStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string CompanyStatusName { get; set; }
    }
}