using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvTypes
    {
        public long TypeId { get; set; }
        public long? GroupId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public double? Mass { get; set; }
        public double? Volume { get; set; }
        public double? Capacity { get; set; }
        public long? PortionSize { get; set; }
        public long? RaceId { get; set; }
        public string BasePrice { get; set; }
        public string Published { get; set; }
        public long? MarketGroupId { get; set; }
        public long? IconId { get; set; }
        public long? SoundId { get; set; }
        public long? GraphicId { get; set; }
    }
}
