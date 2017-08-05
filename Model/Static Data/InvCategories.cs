using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvCategories
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long? IconId { get; set; }
        public string Published { get; set; }
    }
}
