﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }

        public int? UserId { get; set; }
        public string Code { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverName { get; set; }
        public string Note { get; set; }
        public DateTime? CreatAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Status { get; set; }

        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal Price { get; set; }
        public int? Qty { get; set; }
        public decimal Amount { get; set; }



    }
}
