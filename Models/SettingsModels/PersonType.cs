using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels
{
    public class PersonType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string PersonTypeName { get; set; }
    }
}