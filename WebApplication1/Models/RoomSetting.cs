using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.Models
{
    public class RoomSetting
    {
        public Guid ID { get; set; }
        public Guid TenantID { get; set; }
        public Guid FeatureID { get; set; }
        public string Value { get; set; }
        public Guid RoomID { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
