using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Agenda
    {
        private int _idAtencion;

        public int IdAtencion
        {
            get { return _idAtencion; }
            set { _idAtencion = value; }
        }
        private DateTime _fechaAgendamiento;

        public DateTime FechaAgendamiento
        {
            get { return _fechaAgendamiento; }
            set { _fechaAgendamiento = value; }
        }
        private DateTime _fechaInicio;

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        private DateTime _fechaFin;

        public DateTime FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        private int _rutPaciente;

        public int RutPaciente
        {
            get { return _rutPaciente; }
            set { _rutPaciente = value; }
        }
        private int _idTratamiento;

        public int IdTratamiento
        {
            get { return _idTratamiento; }
            set { _idTratamiento = value; }
        }


        private int _idBox;

        public int IdBox
        {
            get { return _idBox; }
            set { _idBox = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
