using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Models.BASE
{
    public abstract class Avion
    {
        public Avion(string piloto, string copiloto, string azafata)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;

        }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public override String ToString()
        {
            return $"Piloto: {Piloto}, Copiloto: {Copiloto}, Azafata: {Azafata}";
        }
        public virtual string Aterriza()
        {
            return "Aterriza ";
        }

        public virtual string Despega()
        {
            return "Despega";
        }
    }
}

//Avion: Piloto, Copiloto, Azafata, Aterriza() y Despega()