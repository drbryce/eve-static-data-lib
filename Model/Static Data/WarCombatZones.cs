using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class WarCombatZones
    {
        public long CombatZoneId { get; set; }
        public string CombatZoneName { get; set; }
        public long? FactionId { get; set; }
        public long? CenterSystemId { get; set; }
        public string Description { get; set; }
    }
}
