using StudentskiResoranVŽ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiResoranVŽ.Repositories
{
    public class MeniRepository
    {

        private List<Meni> _menus;

        public MeniRepository()
        {
            _menus = new List<Meni>
            {
                new Meni
                {
                    ID_meni = 1,
                    Soup = "Bistra juha",
                    Main_Course = "Pečena piletina",
                    Side_Dish = "Zelena salata",
                    Desert = "Kolač"
                },
                new Meni
                {
                    ID_meni = 2,
                    Soup = "Juha od šampinjona",
                    Main_Course = "Pohana svinjetina",
                    Side_Dish = "Đuveč",
                    Desert = "Jogurt"
                },
                new Meni
                {
                    ID_meni = 3,
                    Soup = "Juha od brokule",
                    Main_Course = "Tunjevina s gljivama",
                    Side_Dish = "Tjestenina",
                    Desert = "Voće"
                }
            };
        }

        public List<Meni> GetAllMenus()
        {
            return _menus;
        }

        internal Meni GetMeniById(int selectedMeniId)
        {
            return _menus.FirstOrDefault(m => m.ID_meni == selectedMeniId);
        }
    }
}
