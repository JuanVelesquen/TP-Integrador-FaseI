using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador
{
    public abstract class Operador
    {

        public string Id { get; set; }
        public int bateria { get; set; }
        public string estado { get; set; }
        public int cargaMax { get; set; }
        public double velocidadOptima { get; set; }
        public string localizacion {  get; set; }

        public Operador(string id, int bateria, string estado, int cargaMax, double VelocidadOptima, string localizacion) {
            this.Id = id;
            this.bateria = bateria;
            this.estado = estado;
            this.cargaMax = cargaMax;
            this.velocidadOptima = VelocidadOptima;
            this.localizacion = localizacion;
        }

        public abstract void AsignarOrden(string orden);
        
    }
}
