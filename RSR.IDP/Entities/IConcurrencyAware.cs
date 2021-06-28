using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSR.IDP.Entities
{
    public interface IConcurrencyAware
    {
        string ConcurrencyStamp { get; set; }
    }
}
