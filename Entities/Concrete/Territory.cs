using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Territory :IEntity
    {
        public int TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
    }
}
