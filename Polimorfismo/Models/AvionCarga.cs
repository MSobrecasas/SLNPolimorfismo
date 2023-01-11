using Polimorfismo.Models.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class AvionCarga : Avion
    {
        public AvionCarga(string piloto, string copiloto, string azafata, double peso, string tipoMercaderia) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }

        public double Peso { get; set; }
        public string TipoMercaderia { get; set; }


        /*Compara si los objetos tienen el mismo Piloto*/
        public override bool Equals(object obj)
        {
            var other = (AvionCarga)obj;
            return (this.Piloto == other.Piloto);
        }

        public override string Aterriza()
        {
            return base.Aterriza() + "Avion Carga";
        }

        public override string Despega()
        {
            return base.Despega() + "Avion Carga";
        }

        public override int GetHashCode()
        {
            return -1271473350 + EqualityComparer<string>.Default.GetHashCode(Piloto);
        }
    }
}
