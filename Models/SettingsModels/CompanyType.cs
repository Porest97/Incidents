using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels
{
    public class CompanyType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string CompanyTypeName { get; set; }
    }
}