using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class DgmAttributeTypes
    {
        public long AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public long? IconId { get; set; }
        public double? DefaultValue { get; set; }
        public string Published { get; set; }
        public string DisplayName { get; set; }
        public long? UnitId { get; set; }
        public string Stackable { get; set; }
        public string HighIsGood { get; set; }
        public long? CategoryId { get; set; }
    }
}
