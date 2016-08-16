using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Paciente
    {
        private int _rut;
        private string _dv;
        private string _nombre;
        private string _apaterno;
        private string _amaterno;
        private DateTime _fechaNac;
        private string _direccion;
        private int _fono;
        private int _etapa;

        public int Etapa
        {
            get { return _etapa; }
            set { _etapa = value; }
        }

        public int Fono
        {
            get { return _fono; }
            set { _fono = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public string Amaterno
        {
            get { return _amaterno; }
            set { _amaterno = value; }
        }

        public string Apaterno
        {
            get { return _apaterno; }
            set { _apaterno = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }

        public int Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }
        

    }
}
