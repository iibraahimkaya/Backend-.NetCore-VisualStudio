using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerDemographic : IEntity
    {
        public int CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
    }
}
