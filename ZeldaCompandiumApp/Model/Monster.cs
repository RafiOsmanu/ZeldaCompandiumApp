using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaCompandiumApp.Model
{
    public class Monster
    {
        public string[] Common_locations { get; set; }
        public string Description { get; set; }
        public string[] Drops { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Numb { get; set; }

        public string NumbAndName
        {
            get { return $"{Numb} {Name}"; }
        }
    }
}
