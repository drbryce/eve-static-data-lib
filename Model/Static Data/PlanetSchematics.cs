using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class PlanetSchematics
    {
        public long SchematicId { get; set; }
        public string SchematicName { get; set; }
        public long? CycleTime { get; set; }
    }
}
