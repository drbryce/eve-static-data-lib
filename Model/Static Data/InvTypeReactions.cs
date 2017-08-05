using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvTypeReactions
    {
        public long ReactionTypeId { get; set; }
        public string Input { get; set; }
        public long TypeId { get; set; }
        public long? Quantity { get; set; }
    }
}
