using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class DgmEffects
    {
        public long EffectId { get; set; }
        public string EffectName { get; set; }
        public long? EffectCategory { get; set; }
        public long? PreExpression { get; set; }
        public long? PostExpression { get; set; }
        public string Description { get; set; }
        public string Guid { get; set; }
        public long? IconId { get; set; }
        public string IsOffensive { get; set; }
        public string IsAssistance { get; set; }
        public long? DurationAttributeId { get; set; }
        public long? TrackingSpeedAttributeId { get; set; }
        public long? DischargeAttributeId { get; set; }
        public long? RangeAttributeId { get; set; }
        public long? FalloffAttributeId { get; set; }
        public string DisallowAutoRepeat { get; set; }
        public string Published { get; set; }
        public string DisplayName { get; set; }
        public string IsWarpSafe { get; set; }
        public string RangeChance { get; set; }
        public string ElectronicChance { get; set; }
        public string PropulsionChance { get; set; }
        public long? Distribution { get; set; }
        public string SfxName { get; set; }
        public long? NpcUsageChanceAttributeId { get; set; }
        public long? NpcActivationChanceAttributeId { get; set; }
        public long? FittingUsageChanceAttributeId { get; set; }
        public string ModifierInfo { get; set; }
    }
}
