﻿using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R25.ChangeBiToUni.antes
{
    class Order
    {
        public Customer Customer { get; set; }
    }

    class Customer
    {
        private HashSet<Order> _orders = new HashSet<Order>();
        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }
    }
}
