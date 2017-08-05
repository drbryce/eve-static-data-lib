using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class PlanetSchematicsTypeMap
    {
        public long SchematicId { get; set; }
        public long TypeId { get; set; }
        public long? Quantity { get; set; }
        public string IsInput { get; set; }
    }
}
