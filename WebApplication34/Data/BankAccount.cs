using System;
using System.Collections.Generic;

namespace WebApplication34.Data
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            Transaction = new HashSet<Transaction>();
        }

        public long Id { get; set; }
        public string CmndNumber { get; set; }
        public string Beneficiaries { get; set; }
        public string NumberAccount { get; set; }
        public string Bank { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
