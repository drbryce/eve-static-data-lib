using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvMetaTypes
    {
        public long TypeId { get; set; }
        public long? ParentTypeId { get; set; }
        public long? MetaGroupId { get; set; }
    }
}
