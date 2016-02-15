using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityValuations.Models
{
    public class MunicipalityValuation
    {
        [Key]
        public int MunicipalityValuationId { get; set; }
        public string Period { get; set; }

        [Display(Name = "Lastest GV Date")]
        public DateTime LatestGvDate { get; set; }

        [Display(Name = "VR on File")]
        [UIHint("YesNo")]
        public bool VrOnFile { get; set; }

        [UIHint("YesNo")]
        public bool Rates { get; set; }

        [Display(Name = "Rates Period")]
        public string RatesPeriod { get; set; }

        [UIHint("YesNo")]
        public bool Usage { get; set; }

        [UIHint("YesNo")]
        public bool Complited { get; set; }
        public string Supplimentary { get; set; }
        public int MunicipalityId { get; set; }

        [ForeignKey("MunicipalityId")]
        public virtual Municipality Municipality { get; set; }
    }
}
