using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_automation.Entities.Concrete
{
    public class Deposit
    {
        public int Id { get; set; }
        public int UserNo { get; set; }
        public int BookNo { get; set; }
        public string DepositNote { get; set; }
        public string IsDepositDelivered { get; set; }
        public DateTime BackDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
