using Polimorfismo.Models;
using Polimorfismo.Models.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /****************************************************************************
         * Se pueden sobreescribir los metodos como .Equals .ToString .GetHashCode
         * para obtener un resultado deseado, en este caso sobreescribi el metodo
         * .Equal para verificar si ambos objetos tienen el mismo piloto y en el caso 
         * del .ToString para mostrar los datos de una forma mas facil de leer
         ****************************************************************************/
        private void btnCrearAvionCarga_Click(object sender, EventArgs e)
        {
            AvionCarga avionCarga = new AvionCarga("Jonh Doe", "Juan Perez", "Thalia", 500, "Ropa");
            AvionCarga avionCarga2 = new AvionCarga("Jonh Doe", "Antonio Perez", "Shakira", 500, "Verduras");

            MessageBox.Show(avionCarga.Equals(avionCarga2) ? "Tienen el mismo Piloto" : "No Tienen el mismo Piloto");

        }

        private void btnCrearAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial("Jonh Doe", "Juan Perez", "Thalia", 150, "Argentina Airlines");

            MessageBox.Show(avionComercial.ToString());
        }



    }
}
