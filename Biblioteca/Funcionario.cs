using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Funcionario
    {
        private int _rut;
        private string _dv;

        public string Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }
        private string _nombre;
        private string _paterno;
        private string _materno;
        private int _idCentro;
        private int _idCargo;
        private int _fono;
        private string _email;
        private string _direccion;
        private int _estado;

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Paterno
        {
            get { return _paterno; }
            set { _paterno = value; }
        }

        public string Materno
        {
            get { return _materno; }
            set { _materno = value; }
        }

        public int IdCentro
        {
            get { return _idCentro; }
            set { _idCentro = value; }
        }

        public int IdCargo
        {
            get { return _idCargo; }
            set { _idCargo = value; }
        }

        public int Fono
        {
            get { return _fono; }
            set { _fono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
    }
}
