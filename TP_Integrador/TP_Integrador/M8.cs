using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador
{
    public class M8 : Operador
    {
        public M8(string identificador, int bateria, string estado, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(identificador, bateria, estado, cargaMaxima, velocidadOptima, localizacion)
        {
            // Agregar atributos específicos de M8
        }

        public override void AsignarOrden(string orden)
        {
            //Sin determinar
        }

        public void Desplazarse(string destino)
        {
            //Sin determinar
        }
    }
}
