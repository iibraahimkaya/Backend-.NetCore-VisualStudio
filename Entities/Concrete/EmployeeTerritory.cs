using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EmployeeTerritory :IEntity
    {
        public int EmployeeID { get; set; }
        public string TerritoryID { get; set; }

    }
}
