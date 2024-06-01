using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Models
{
    public class OrderHistory
    {
        private static int _nextOrderId = 1;
        public int OrderId { get;  }
        public Meni SelectedMeni { get; set; }

        public OrderHistory()
        {
            OrderId = _nextOrderId++;
        }
    }
}
