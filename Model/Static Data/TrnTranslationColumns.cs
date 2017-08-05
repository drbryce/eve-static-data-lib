using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class TrnTranslationColumns
    {
        public long? TcGroupId { get; set; }
        public long TcId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string MasterId { get; set; }
    }
}
