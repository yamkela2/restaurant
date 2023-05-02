﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAppRestaurantDemoApp.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int PaymentTypeId { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get { return DateTime.Now; } }
        public decimal FinalTotal { get; set; }
        public IEnumerable<OrderDetailViewModel> listOrderDetailViewModel { get; set; }
    }
}