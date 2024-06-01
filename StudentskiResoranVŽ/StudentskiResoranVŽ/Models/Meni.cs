using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Models
{
    public class Meni
    {
        public int ID_meni { get; set; }
        public string Soup { get; set; }
        public string Main_Course { get; set; }
        public string Side_Dish { get; set; }
        public string Desert { get; set; }
        public override string ToString()
        {
            return $"{Soup}, {Main_Course}, {Side_Dish}, {Desert}";
        }
    }
}
