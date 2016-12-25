using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProjekt
{
    class Djur
    {
        public int MittDjur { get; set; }

        [Required]
        public string Namn { get; set; }
        public int Ålder { get; set; }
        public int Vikt { get; set; }
    }
}
