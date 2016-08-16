using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Biblioteca
{
     public class Usuario
    {
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private int rutFuncionario;

        public int RutFuncionario
        {
            get { return rutFuncionario; }
            set { rutFuncionario = value; }
        }
        private int idCentro;

        public int IdCentro
        {
            get { return idCentro; }
            set { idCentro = value; }
        }
    }

}
