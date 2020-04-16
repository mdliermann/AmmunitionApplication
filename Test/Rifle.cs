using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Rifle
    {
        private string makeModel;
        private string caliber;
        private string barrel;
        private string scope;

        public Rifle(string makeModel, string caliber, string barrel, string scope)
        {
            this.MakeModel = makeModel;
            this.Caliber = caliber;
            this.Barrel = barrel;
            this.Scope = scope;
        }

        public string MakeModel { get => makeModel; set => makeModel = value; }
        public string Caliber { get => caliber; set => caliber = value; }
        public string Barrel { get => barrel; set => barrel = value; }
        public string Scope { get => scope; set => scope = value; }
    }
}
