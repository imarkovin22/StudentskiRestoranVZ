using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Models
{
    internal class OrderHistory
    {
        public int ID_order { get; set; }
        public string Soup { get; set; }
        public string Main_Course { get; set; }
        public string Side_Dish { get; set; }
        public string Desert { get; set; }
        public override string ToString()
        {
            return $"ID_order: {ID_order}, Soup: {Soup}, Main_Course: {Main_Course}, Side_Dish: {Side_Dish}, Desert: {Desert}";
        }
    }
}
