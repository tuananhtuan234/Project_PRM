﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Data.DTOs.Order
{
    public class UpdateOrderDtos
    {
        public string LocationId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public float TotalPrice { get; set; }
    }
}
