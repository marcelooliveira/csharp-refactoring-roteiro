using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R24.ChangeUniToBi.depois
{
    class Order
    {
        private HashSet<Customer> _customers = new HashSet<Customer>();
        public IEnumerable<Customer> Customers
        {
            get { return _customers; }
        }

        public void AddCustomer(Customer customer)
        {
            customer.FriendOrders.Add(this);
            _customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customer.FriendOrders.Remove(this);
            _customers.Remove(customer);
        }
    }

    class Customer
    {
        private HashSet<Order> _orders = new HashSet<Order>();
        public IEnumerable<Order> Orders
        {
            get { return _orders; }
        }

        internal HashSet<Order> FriendOrders
        {
            get { return _orders; }
        }

        public void AddOrder(Order order)
        {
            order.AddCustomer(this);
        }

        public void RemoveCustomer(Order order)
        {
            order.RemoveCustomer(this);
        }
    }
}
