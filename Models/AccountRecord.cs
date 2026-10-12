using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAccounting.Models
{
    public class AccountRecord
    {
        public int Id { get; set; }
        public DateTime RecordDate { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public string Remark { get; set; }
    }
}
