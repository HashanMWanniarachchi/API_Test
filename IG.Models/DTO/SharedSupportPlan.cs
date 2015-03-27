using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG.Models.DTO
{
    public class SharedSupportPlan
    {
        public virtual tblINIServiceCoordinationPlan PallativeCareSymptom { get; set; }
        public virtual tblINIServiceCoordinationPlanInvitee ServiceCoordinationPlanInvitee { get; set; }
    }
}
