using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class MapSolarSystems
    {
        public long? RegionId { get; set; }
        public long? ConstellationId { get; set; }
        public long SolarSystemId { get; set; }
        public string SolarSystemName { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }
        public double? XMin { get; set; }
        public double? XMax { get; set; }
        public double? YMin { get; set; }
        public double? YMax { get; set; }
        public double? ZMin { get; set; }
        public double? ZMax { get; set; }
        public double? Luminosity { get; set; }
        public string Border { get; set; }
        public string Fringe { get; set; }
        public string Corridor { get; set; }
        public string Hub { get; set; }
        public string International { get; set; }
        public string Regional { get; set; }
        public string Constellation { get; set; }
        public double? Security { get; set; }
        public long? FactionId { get; set; }
        public double? Radius { get; set; }
        public long? SunTypeId { get; set; }
        public string SecurityClass { get; set; }
    }
}
