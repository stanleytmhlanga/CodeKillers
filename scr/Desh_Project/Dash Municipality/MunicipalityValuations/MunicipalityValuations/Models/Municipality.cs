using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityValuations.Models
{
    public class Municipality
    {
        public Municipality()
        {
            Valuations = new List<MunicipalityValuation>();
        }

        [Key]
        public int MunicipalityId { get; set; }

        [Required]
        [Display(Name = "Municipality Name")]
        public string Name { get; set; }

        [Display(Name = "Municipality Identification Number")]
        public int MunicipalityIdentificationNumber { get; set; }
        public virtual ICollection<MunicipalityValuation> Valuations  { get; set; }
    }
}
