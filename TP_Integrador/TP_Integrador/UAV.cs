using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador
{
    public class UAV : Operador
    {
        public UAV(string identificador, int bateria, string estado, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(identificador, bateria, estado, cargaMaxima, velocidadOptima, localizacion)
        {
            // Agregar atributos específicos de UAV
        }

        public override void AsignarOrden(string orden)
        {
            //Sin determinar
        }

        public void Volar(string destino)
        {
            //Sin determinar
        }
    }

}
