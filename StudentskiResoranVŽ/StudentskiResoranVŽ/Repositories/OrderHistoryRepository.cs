using StudentskiResoranVŽ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Repositories
{
    public class OrderHistoryRepository
    {
        private readonly List<OrderHistory> _orders = new List<OrderHistory>();

        public void SaveOrder(OrderHistory order)
        {
            _orders.Add(order);
        }

        public List<OrderHistory> GetAllOrders()
        {
            return _orders;
        }

    }
}
