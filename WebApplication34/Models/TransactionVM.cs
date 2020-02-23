using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace WebApplication34.Models
{
    public class TransactionVM : WebApplication34.Data.Transaction
    {
        public bool Check { get; set; } = false;
    }
}
