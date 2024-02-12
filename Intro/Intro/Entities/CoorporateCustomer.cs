using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

internal class CoorporateCustomer : BaseCustomer
{
    public int Id { get; set; }
    public string CustomerNnumber { get; set; }
    public string Name { get; set; }
    public string TaxNumber { get; set; }

}
