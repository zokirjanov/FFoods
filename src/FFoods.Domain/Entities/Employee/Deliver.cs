using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Domain.Entities.Employee
{
    public class Deliver : Person
    {
        public string PassportSeria { get; set; } = String.Empty;

        public int PassportNumber { get; set; }
    }
}
