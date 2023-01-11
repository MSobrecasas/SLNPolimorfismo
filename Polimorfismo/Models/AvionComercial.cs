using Polimorfismo.Models.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string piloto, string copiloto, string azafata, double capacidad, string lineaAerea) : base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public double Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public override String ToString()
        {
            return base.ToString() + $"Capacidad: {Capacidad}, Linea Aerea: {LineaAerea}";
        }

        public override string Aterriza()
        {
            return base.Aterriza() + "Avion Comercial";
        }

        public override string Despega()
        {
            return base.Despega() + "Avion Comercial";
        }


    }
}
