using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.Models.DTO
{
    public class PallativeCareDTO
    {
        public virtual tblINIPallativeCareSymptom PallativeCareSymptom { get; set; }
        public virtual tblINIPallativeCareAssessment PallativeCareAssessment { get; set; }
        public virtual tblINIPallativeCare PallativeCare { get; set; }
        public virtual tblINIProfile Profile { get; set; }
        public virtual tblAddress Address { get; set; }
        public virtual tblLGA LGA { get; set; }
        public virtual tblPersonAddress PersonAddress { get; set; }
        public virtual tblRegion Region { get; set; }
        public virtual tblState State { get; set; }
        public virtual tblSuburb Suburb { get; set; }
        public virtual tblContactDetail ContactDetail { get; set; }
        public virtual tblContactDetailsType ContactDetailsType { get; set; }
        public virtual tblPerson Person { get; set; }
    }
}
