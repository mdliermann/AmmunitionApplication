using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Projectile
    {
        private string pn;
        private string brand;
        private decimal diameter;
        private string description;
        private string weight;
        private decimal bc_g1;
        private decimal bc_g7;

        public Projectile(string pn, string brand, decimal diameter, string description, string weight, decimal bc_g1, decimal bc_g7)
        {
            Pn = pn;
            Brand = brand;
            Diameter = diameter;
            Description = description;
            Weight = weight;
            this.bc_g1 = bc_g1;
            this.bc_g7 = bc_g7;
            Diameter = diameter;
        }

        public decimal Diameter { get => diameter; set => diameter = value; }
        public string Pn { get => pn; set => pn = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Description { get => description; set => description = value; }
        public string Weight { get => weight; set => weight = value; }
        public decimal BC_G1 { get => bc_g1; set => bc_g1 = value; }
        public decimal BC_G7 { get => bc_g7; set => bc_g7 = value; }

    }
}
