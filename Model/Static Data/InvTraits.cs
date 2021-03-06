﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvTraits
    {
        public long TraitId { get; set; }
        public long? TypeId { get; set; }
        public long? SkillId { get; set; }
        public double? Bonus { get; set; }
        public string BonusText { get; set; }
        public long? UnitId { get; set; }
    }
}
