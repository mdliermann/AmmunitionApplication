using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Primer
    {
        private string description;

        public Primer(string description)
        {
            Description = description;
        }

        public string Description { get => description; set => description = value; }
    }
}
