using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador
{
    public class K9 : Operador
    {
        public K9(string identificador, int bateria, string estado, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(identificador, bateria, estado, cargaMaxima, velocidadOptima, localizacion)
        {
            // Agregar atributos específicos de K9
        }

        public override void AsignarOrden(string orden)
        {
            //Sin determinar
        }

        public void Moverse(string destino)
        {
            //Sin determinar
        }
    }
}
