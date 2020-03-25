using System.ComponentModel.DataAnnotations;

namespace Incidents.Models.SettingsModels
{
    public class PersonStatus
    {
        public int Id { get; set; }

        [Display(Name ="Status")]
        public string PersonStatusName { get; set; }
    }
}