using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rellotge
{
    [Serializable()]
    class Alarma
    {
        private String Hora;
        public bool Activa { get; set; }

        public Alarma()
        {
            Hora = "00:00";
            Activa = false;
        }

        public Alarma(String alarma, bool activa)
        {
            Hora = alarma;
            Activa = activa;
        }

        public String horaAlarma
        {
            get { return Hora; }
            set { Hora = value; }
        }
    }
}
