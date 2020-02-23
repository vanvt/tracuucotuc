using System;
using System.Collections.Generic;

namespace WebApplication34.Data
{
    public partial class ChangeHistory
    {
        public long Id { get; set; }
        public string CmndNumber { get; set; }
        public string Content { get; set; }
        public DateTime? Created { get; set; }
    }
}
