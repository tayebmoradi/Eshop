﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Products.Dtos
{
    public class OrderStatusInputDto
    {
        public string? Title { get; set; }
    }
    public class OrderStatusOutputDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }
    }
}