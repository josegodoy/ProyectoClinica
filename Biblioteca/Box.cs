using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Box
    {
        private int _idBox;
        private int _idCentro;
        private int _idTipo;
        private int _idTamano;
        private int _idEstado;

        public int IdEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        public int IdTamano
        {
            get { return _idTamano; }
            set { _idTamano = value; }
        }

        public int IdTipo
        {
            get { return _idTipo; }
            set { _idTipo = value; }
        }

        public int IdCentro
        {
            get { return _idCentro; }
            set { _idCentro = value; }
        }

        public int IdBox
        {
            get { return _idBox; }
            set { _idBox = value; }
        }



    }
}
