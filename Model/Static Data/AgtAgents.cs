using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class AgtAgents
    {
        public long AgentId { get; set; }
        public long? DivisionId { get; set; }
        public long? CorporationId { get; set; }
        public long? LocationId { get; set; }
        public long? Level { get; set; }
        public long? Quality { get; set; }
        public long? AgentTypeId { get; set; }
        public string IsLocator { get; set; }
    }
}
