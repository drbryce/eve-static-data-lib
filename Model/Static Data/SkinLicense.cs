using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class SkinLicense
    {
        public long LicenseTypeId { get; set; }
        public long? Duration { get; set; }
        public long? SkinId { get; set; }
    }
}
