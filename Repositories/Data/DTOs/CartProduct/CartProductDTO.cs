﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Data.DTOs.CartProduct
{
    public class CartProductDTO
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
