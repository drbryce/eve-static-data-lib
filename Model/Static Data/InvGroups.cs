using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvGroups
    {
        public long GroupId { get; set; }
        public long? CategoryId { get; set; }
        public string GroupName { get; set; }
        public long? IconId { get; set; }
        public string UseBasePrice { get; set; }
        public string Anchored { get; set; }
        public string Anchorable { get; set; }
        public string FittableNonSingleton { get; set; }
        public string Published { get; set; }
    }
}
