using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek1
{
    public class menu
    {
        private List<string> _menu;

        public string Name { get; set; }
        public int Harga { get; set; }
        public bool Status { get; set; }

        public menu()
        {
            Name = "Bakso";
            Harga = 15000;
            Status = true;

            _menu = new List<string>()
            {
                "Bakso; 15000; true;",
                "Siomay; 10000; true;",
                "Pizza; 35000; true;"
            };
        }
        public string Info()
        {
            var info = $"Nama: {Name}" + $"Harga: {Harga}; Status: {Status}";
            return info;
        }

        public void Create(string menu)
        {
            _menu.Add(menu);
        }

        public List<string> Read()
        {
            return _menu;
        }

        public void Update(string menu)
        {
            _menu.Remove(menu);
            _menu.Add(menu);
        }
        public void Delete(string menu)
        {
            _menu.Remove(menu);
        }



    }
}
