using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels
{
    public class CompanyRole
    {
        public int Id { get; set; }

        [Display(Name ="Role")]
        public string CompanyRoleName { get; set; }
    }
}