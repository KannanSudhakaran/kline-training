using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01ConsoleEFCore.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public override string ToString()
        {
            return $"Id:{Id}, FirstName:{FirstName}";
        }
    }
}
