using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Models
{
    internal class Meni
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

        public static Meni meni1 { get; } = new Meni()
        {
            ID_meni = 1,
            Soup = "Bistra juha",
            Main_Course = "Pečena piletina",
            Side_Dish = "Zelena salata",
            Desert = "Kolač",
        };

        public static Meni meni2 { get; } = new Meni()
        {
            ID_meni = 2,
            Soup = "Juha od šampinjona",
            Main_Course = "Pohana svinjetina",
            Side_Dish = "Đuveč",
            Desert = "Jogurt",
        };

        public static Meni meni3 { get; } = new Meni()
        {
            ID_meni = 3,
            Soup = "Juha od brokule",
            Main_Course = "Tunjevina s gljivama",
            Side_Dish = "Tjestenina",
            Desert = "Voće",
        };
    }
}
