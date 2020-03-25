using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels

{
    public class PersonRole
    {
        public int Id { get; set; }

        [Display(Name ="Role")]
        public string PersonRoleName { get; set; }
    }
}