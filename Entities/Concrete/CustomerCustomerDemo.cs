﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerCustomerDemo :IEntity
    {
        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
