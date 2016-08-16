using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;

namespace Biblioteca
{
    public class fx
    {
        public static void agregarFuncionario(Biblioteca.Funcionario f) {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("INSERTAR_FUNCIONARIO", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = f.Rut;
            comando.Parameters.Add("v_dv", OracleDbType.Varchar2).Value = f.Dv;
            comando.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = f.Nombre;
            comando.Parameters.Add("v_paterno", OracleDbType.Varchar2).Value = f.Paterno;
            comando.Parameters.Add("v_materno", OracleDbType.Varchar2).Value = f.Materno;
            comando.Parameters.Add("v_centro", OracleDbType.Int32).Value = f.IdCentro;
            comando.Parameters.Add("v_cargo", OracleDbType.Int32).Value = f.IdCargo;
            comando.Parameters.Add("v_fono", OracleDbType.Int32).Value = f.Fono;
            comando.Parameters.Add("v_email", OracleDbType.Varchar2).Value = f.Email;
            comando.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = f.Direccion;
            comando.ExecuteNonQuery();
            c.Close();
        
        
        
        }

        public static void agregarUsuario(Biblioteca.Usuario u)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            //string consulta;
            c.Open();
            //consulta = "INSERT INTO USUARIO VALUES('" + u.User + "','" + u.Pass + "'," + u.RutFuncionario + "," + u.IdCentro + ")";
            comando = new OracleCommand("CREAR_USUARIO", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_usuario", OracleDbType.Varchar2).Value = u.User;
            comando.Parameters.Add("v_contrasena", OracleDbType.Varchar2).Value = u.Pass;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = u.RutFuncionario;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void eliminarFuncionario(int rut)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("ELIMINAR_FUNCIONARIO", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = rut;
            comando.ExecuteNonQuery();
            c.Close();

        }

        public static void editarFuncionario(Biblioteca.Funcionario f)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("MODIFICAR_FUNCIONARIO", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = f.Rut;
            //comando.Parameters.Add("v_dv", OracleDbType.Varchar2).Value = f.Dv;
            comando.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = f.Nombre;
            comando.Parameters.Add("v_paterno", OracleDbType.Varchar2).Value = f.Paterno;
            comando.Parameters.Add("v_materno", OracleDbType.Varchar2).Value = f.Materno;
            comando.Parameters.Add("v_centro", OracleDbType.Int32).Value = f.IdCentro;
            comando.Parameters.Add("v_cargo", OracleDbType.Int32).Value = f.IdCargo;
            comando.Parameters.Add("v_fono", OracleDbType.Int32).Value = f.Fono;
            comando.Parameters.Add("v_email", OracleDbType.Varchar2).Value = f.Email;
            comando.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = f.Direccion;
            comando.Parameters.Add("v_estadofun", OracleDbType.Int32).Value = f.Estado;
            comando.ExecuteNonQuery();
            c.Close();


        }

        public static DataTable buscarFuncionariosDisponibles()
        {
            string query = "select rut_fun as rut, apaterno_fun || ' ' || amaterno_fun || ' ' || nombre_fun  as nombre , nombre_cargo as cargo from funcionario f join cargo ca on f.cargo_id_cargo = ca.id_cargo where id_estado = 1 and activo = 'Y' order by apaterno_fun";
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static DataTable oracleTable(string query)
        {
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            DataSet oDataSet = new DataSet();
            DataTable oTabla = default(DataTable);
            OracleDataAdapter datos = new OracleDataAdapter(query, c);
            c.Open();
            datos.Fill(oDataSet, "tabla");
            oTabla = oDataSet.Tables[0];
            c.Close();
            return oTabla;
        }

        public static string oracleString(string query)
        {
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            //oConexion.ConnectionString = conexion;
            OracleDataAdapter oConsulta = new OracleDataAdapter(query, c);
            DataSet oDataSet = new DataSet();
            DataTable oTabla = default(DataTable);
            c.Open();
            oConsulta.Fill(oDataSet, "tabla");
            string salida = "";

            if (oDataSet.Tables.Count > 0)
            {
                oTabla = oDataSet.Tables[0];
                if (oTabla.Rows.Count > 0)
                {
                    DataRow dato = oTabla.Rows[0];
                    salida = dato[0].ToString();
                }
                else
                {
                    salida = "";
                }
            }

            c.Close();
            return salida;
        }

        public static string obtenerDv(string r)
        {
            int suma = 0;
            for (int x = r.Length - 1; x >= 0; x--)
                suma += int.Parse(char.IsDigit(r[x]) ? r[x].ToString() : "0") * (((r.Length - (x + 1)) % 6) + 2);
            int numericDigito = (11 - suma % 11);
            string digito = numericDigito == 11 ? "0" : numericDigito == 10 ? "K" : numericDigito.ToString();
            return digito;
        }

        public static DataTable obtenerCargos()
        {
            string query = "select * from cargo";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerCentros()
        {
            string query = "select * from centro where id_centro > 1";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerFuncionario(string rut)
        {
            string query = "select rut_fun,dv_rut_fun,nombre_fun,apaterno_fun,amaterno_fun,nombre_cargo,nombre_centro,fono_funcionario,email,direccion_funcionario,nombre_estado from FUNCIONARIO f join cargo c on c.ID_CARGO = f.CARGO_ID_CARGO join centro cen on cen.ID_CENTRO = f.CENTRO_ID_CENTRO join estado_fun est on f.id_estado = est.id_estado  where activo = 'Y' and  f.RUT_FUN ='" + rut + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerUsuarios()
        {
            string query = "select f.NOMBRE_FUN,f.APATERNO_FUN,usuario_sistema , contrasena , f.cargo_id_cargo,nombre_cargo,id_centro,nombre_centro from usuario u join funcionario f on u.funcionario_rut_fun = f.rut_fun join cargo ca on f.cargo_id_cargo = ca.id_cargo join centro c on f.centro_id_centro = c.ID_CENTRO";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerExisteFuncionario(string rut, string email, string fono)
        {
            string query = "Select rut_fun, email, fono_funcionario from funcionario where rut_fun ='" + rut + "' or email ='"+ email + "' or fono_funcionario ='" + fono + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static string obtenerExisteUsuario(string user)
        {
            string query = "select usuario_sistema from usuario where usuario_sistema = '" + user + "'";
            string r = oracleString(query);
            return r;
        }

        public static DataTable obtenerEstadoFun()
        {
            string query = "select * from ESTADO_FUN";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerEnfermeras(string id)
        {
            string query = "select rut_fun, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from enfermerasbox where id_estado = 1 and centro_id_centro ='"+ id + "' order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerKinesiologos(string id)
        {
            string query = "select rut_fun, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from kinesiologos where id_estado = 1 and centro_id_centro ='" + id + "' order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerFonoaudiologos(string id)
        {
            string query = "select rut_fun, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from fonoaudiologos where id_estado = 1 and centro_id_centro ='" + id + "' order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerAuxiliares(string id)
        {
            string query = "select rut_fun, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from auxiliares where id_estado = 1 and centro_id_centro ='" + id + "' order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerMedicos()
        {
            string query = "select rut_fun, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from medicos where id_estado = 1 order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

       

        //Box

        public static void agregarBox(Biblioteca.Box b)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_BOX.CREAR_BOX", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_centro", OracleDbType.Int32).Value = b.IdCentro;
            comando.Parameters.Add("v_tipo", OracleDbType.Int32).Value = b.IdTipo;
            comando.Parameters.Add("v_tamano", OracleDbType.Int32).Value = b.IdTamano;
            comando.ExecuteNonQuery();
            c.Close();
        }      

        public static void editarBox(Biblioteca.Box b)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_BOX.MODIFICAR_BOX", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id", OracleDbType.Int32).Value = b.IdBox;
            comando.Parameters.Add("v_tamano", OracleDbType.Int32).Value = b.IdTamano;
            comando.Parameters.Add("v_tipo", OracleDbType.Int32).Value = b.IdTipo;
            comando.Parameters.Add("v_estado", OracleDbType.Int32).Value = b.IdEstado;
            comando.ExecuteNonQuery();
            c.Close();
        }
        
        public static string obtenerIdBox()
        {

            string query = "select max (id_box)+ 1 from box";
            string res = oracleString(query);
            return res;

        }

        public static DataTable obtenerBox()
        {
            string query = "Select * from box";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerBoxCentro(string centro)
        {
            string query = "Select * from box where centro_id_centro = '" + centro + "' order by id_box";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerBoxId(string id)
        {
            string query = "Select * from box where id_box ='" + id + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerTipoBox()
        {
            string query = "Select * from tipo";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerTamBox()
        {
            string query = "select * from tamano";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerEstadoBox()
        {
            string query = "Select * from estado";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static string cantidadBox(string id)
        {
            string query = "Select count(id_box) from box where centro_id_centro = '"+ id + "'";
            string r = oracleString(query);
            return r;
        }

        public static DataTable reporteBox(string id)
        {
            string query = "Select * from reporteBox where NumeroBox = '" + id + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable reporteBoxPdf(string id)
        {
            string query = "Select * from reporteBox where IDATENCION = '" + id + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        

        public static DataTable listarBox(string id)
        {
            string query = "select id_box,nombre_centro,b.estado_id_estado,estado,tamano,nombre_tipo from box b join centro ce on b.centro_id_centro = ce.id_centro " +
                           " join tipo t on b.tipo_id_tipo = t.id_tipo  join tamano ta on b.tamano_id_tamano = ta.id_tamano " +
                           " join estado e on b.estado_id_estado = e.id_estado where b.centro_id_centro ='"+ id + "' order by b.id_box" ;
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static DataTable listarBox()
        {
            string query = "select id_box,nombre_centro,b.estado_id_estado,estado,tamano,nombre_tipo from box b join centro ce on b.centro_id_centro = ce.id_centro " +
                           " join tipo t on b.tipo_id_tipo = t.id_tipo  join tamano ta on b.tamano_id_tamano = ta.id_tamano " +
                           " join estado e on b.estado_id_estado = e.id_estado";
            DataTable dt = oracleTable(query);
            return dt;
        }


        //Paciente
        public static void agregarPaciente(Biblioteca.Paciente p)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_PACIENTE.INSERTAR_PACIENTE", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut_pac", OracleDbType.Int32).Value = p.Rut;
            comando.Parameters.Add("v_dv_rut", OracleDbType.Varchar2).Value = p.Dv;
            comando.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = p.Nombre;
            comando.Parameters.Add("v_apaterno", OracleDbType.Varchar2).Value = p.Apaterno;
            comando.Parameters.Add("v_amaterno", OracleDbType.Varchar2).Value = p.Amaterno;
            comando.Parameters.Add("v_fecha_nac", OracleDbType.Date).Value = p.FechaNac;
            comando.Parameters.Add("v_direccion_pac", OracleDbType.Varchar2).Value = p.Direccion;
            comando.Parameters.Add("v_fono_pac", OracleDbType.Int32).Value = p.Fono;
            comando.Parameters.Add("v_id_etapa", OracleDbType.Int32).Value = p.Etapa;
            comando.ExecuteNonQuery();
            c.Close();



        }

        public static void editarPaciente(Biblioteca.Paciente p)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_PACIENTE.MODIFICAR_PACIENTE", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut_pac", OracleDbType.Int32).Value = p.Rut;
            comando.Parameters.Add("v_dv_rut", OracleDbType.Int32).Value = p.Dv;
            comando.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = p.Nombre;
            comando.Parameters.Add("v_apaterno", OracleDbType.Varchar2).Value = p.Apaterno;
            comando.Parameters.Add("v_amaterno", OracleDbType.Varchar2).Value = p.Amaterno;
            comando.Parameters.Add("v_fecha_nac", OracleDbType.Date).Value = p.FechaNac;
            comando.Parameters.Add("v_direccion_pac", OracleDbType.Varchar2).Value = p.Direccion;
            comando.Parameters.Add("v_fono_pac", OracleDbType.Int32).Value = p.Fono;
            comando.Parameters.Add("v_id_etapa", OracleDbType.Int32).Value = p.Etapa;
            comando.ExecuteNonQuery();
            c.Close();


        }

        public static void cambiarEtapaPaciente(int rut , int etapa)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_PACIENTE.MODIFICAR_ETAPA", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = rut;
            comando.Parameters.Add("v_id_etapa", OracleDbType.Int32).Value = etapa;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void agregarSesionPaciente(int rut)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_PACIENTE.AGREGAR_SESION_PACIENTE", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = rut;
            comando.ExecuteNonQuery();
            c.Close();

        }

        public static void agregarSesionFinPaciente(int rut)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_PACIENTE.AGREGAR_SESIONFIN_PACIENTE", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = rut;
            comando.ExecuteNonQuery();
            c.Close();

        }


        public static string obtenerExistePac(string rut)
        {
            string query = ("Select rut_paciente from paciente where rut_paciente = '" + rut + "'");
            string rutPac = oracleString(query);
            return rutPac;


        }

        public static string obtenerNombrePaciente(int rut)
        {
            string query = "select nombre_paciente || ' ' || apaterno_paciente ||' '|| amaterno_paciente from paciente where rut_paciente=" + rut + "";
            string resultado = oracleString(query);
            return resultado;
        }

        public static DataTable obtenerPaciente(string rut)
        {
            string query = "select rut_paciente,dv_rut_paciente,nombre_paciente,apaterno_paciente,amaterno_paciente,fecha_nacimiento,direccion_paciente,fono_paciente,cantidad_sesiones,sesiones_finalizadas,et.NOMBRE from PACIENTE pa JOIN ETAPA et on pa.ID_ETAPA = et.ID_ETAPA where rut_paciente ='" + rut + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerPacientes()
        {
            string query = "Select * from paciente";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static string obtenerRutPacienteSesion(string id)
        {
            string query = "Select rut_paciente from agenda where id_atencion ='" + id  +"'";
            string rutP = oracleString(query);
            return rutP;
        }

        public static string obtenerEmailEnfermera(string id)
        {
            string query = "select email from funcionario f join equipo_medico em  on f.rut_fun = em.rut_funcionario join agenda ag on ag.id_atencion = em.id_atencion where cargo_id_cargo = 3 and ag.id_atencion ='"+id+"'";
            string result = oracleString(query);
            return result;
        }

        public static string obtenerEdadPaciente(int rut)
        {
            string query = "select round(months_between(sysdate,fecha_nacimiento)/12) from paciente where rut_paciente =" + rut + "";
            string result = oracleString(query);
            return result;
        }

        public static string buscarPacientePorRut(int rut)
        {
            string query = "select rut_paciente from paciente where rut_paciente =" + rut + "";
            string resultado = oracleString(query);
            return resultado;
        }



        // obtencion del equipo medico segun fecha de agendamiento
        public static DataTable obtenerEquipoMedico(string fecha)
        {

            string query = "select eq.id_atencion ,rut_funcionario ,Nombre_fun ,apaterno_fun ,c.NOMBRE_CARGO ,to_char(fecha_agendamiento,'DD/MM/YYYY')AS FechaAgendamiento from EQUIPO_MEDICO eq join FUNCIONARIO fun on eq.rut_funcionario = fun.RUT_FUN join cargo c on c.ID_CARGO = fun.CARGO_ID_CARGO JOIN AGENDA AG ON AG.ID_ATENCION = eq.id_atencion where to_char(fecha_agendamiento,'DD-MM-YYYY') ='" + fecha + "'";
            DataTable tb = oracleTable(query);
            return tb;

        }

        public static void agregarEquipoMedico(int rutFun, int idAgenda)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            //string consulta;
            c.Open();
            //consulta = "INSERT INTO USUARIO VALUES('" + u.User + "','" + u.Pass + "'," + u.RutFuncionario + "," + u.IdCentro + ")";
            comando = new OracleCommand("insertar_equipo_medico", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut", OracleDbType.Int32).Value = rutFun;
            comando.Parameters.Add("v_id", OracleDbType.Int32).Value = idAgenda;
            comando.ExecuteNonQuery();
            c.Close();
        }




        //Agenda
        public static void crearSesion(Biblioteca.Agenda a)
        {

            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_AGENDA.INSERTAR_SESION", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_fecha_inicio", OracleDbType.Date).Value = a.FechaInicio;
            comando.Parameters.Add("v_rut_paciente", OracleDbType.Int32).Value = a.RutPaciente;
            //comando.Parameters.Add("v_fecha_final", OracleDbType.Date).Value = a.FechaFin;
           // comando.Parameters.Add("v_fecha_agendamiento", OracleDbType.Date).Value = a.FechaAgendamiento;
            comando.Parameters.Add("v_id_tratamiento", OracleDbType.Int32).Value = a.IdTratamiento;
            //comando.Parameters.Add("v_id_box", OracleDbType.Int32).Value = a.IdBox;
            comando.Parameters.Add("v_descripcion", OracleDbType.Varchar2).Value = a.Descripcion;
            comando.ExecuteNonQuery();
            c.Close();

        }

        public static void obtenerHoraFinal(Biblioteca.Agenda a)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("sacar_Hora_Final", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id", OracleDbType.Int32).Value = a.IdAtencion;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void modificarSesion(Biblioteca.Agenda ag)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_AGENDA.MODIFICAR_SESION", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id_atencion", OracleDbType.Int32).Value = ag.IdAtencion;
            comando.Parameters.Add("v_fecha_inicio", OracleDbType.Date).Value = ag.FechaInicio;
            comando.Parameters.Add("v_fecha_final", OracleDbType.Date).Value = ag.FechaFin;
            comando.Parameters.Add("v_fecha_agendamiento", OracleDbType.Date).Value = ag.FechaAgendamiento;
            //comando.Parameters.Add("v_id_tratamiento", OracleDbType.Int32).Value = ag.IdTratamiento;
            comando.Parameters.Add("v_id_box", OracleDbType.Int32).Value = ag.IdBox;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static string obtenerIdSesion()
        {
            string query = "select max (id_atencion) + 1 from agenda";
            string r = oracleString(query);
            return r;
        }

        public static DataTable obtenerFichaPaciente(string id)
        {
            string query = "select ag.id_atencion,nombre_centro,p.rut_paciente || '-' || dv_rut_paciente as rut, nombre_paciente || ' ' || apaterno_paciente || ' ' || amaterno_paciente as nombre,et.nombre as etapa, " +
                            " fono_paciente,to_char(fecha_nacimiento, 'dd/MM/yyyy') as fechaNacimiento,direccion_paciente,nombre_fun|| ' ' || apaterno_fun as nombre_fun,nombre_cargo,tratamiento,descripcion,fecha_agendamiento,fecha_inicio " +
                            " from paciente p join agenda ag on p.rut_paciente = ag.rut_paciente " +
                            " join equipo_medico em on em.id_atencion = ag.id_atencion " +
                            " join funcionario f on f.rut_fun = em.rut_funcionario " +
                            " join cargo ca on f.cargo_id_cargo = ca.id_cargo " +
                            " join centro ce on f.centro_id_centro = ce.id_centro " +
                            " join etapa et on et.id_etapa = p.id_etapa " +
                            " join tratamiento tr on ag.id_tratamiento = tr.id_tratamiento " +
                            " where ag.id_atencion ='" + id + "'";
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static DataTable obtenerSesionPorId(string id)
        {
            string query = "select ag.id_atencion, p.rut_paciente as rut, nombre_paciente ||' '|| apaterno_paciente || ' ' || amaterno_paciente as nombre_paciente, " +
                            " id_box, tratamiento,descripcion, fecha_agendamiento, fecha_inicio,fecha_final,rut_funcionario, ag.id_tratamiento " +
                            " from agenda ag join paciente p on ag.rut_paciente = p.rut_paciente " +
                            " join tratamiento t on ag.id_tratamiento = t.id_tratamiento " +
                            " join equipo_medico em on ag.id_atencion = em.id_atencion " +
                            " where ag.id_atencion ='" + id + "'";
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static DataTable obtenerTratamiento()
        {
            string query = "select * from tratamiento";
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static DataTable obtenerSesiones(string fechaInicio, string fechaFin, int tratamiento,string idCentro)
        {
            string query = "select ag.id_atencion, to_char(fecha_agendamiento, 'dd/MM/yyyy') as fecha_agendamiento,to_char(fecha_agendamiento, 'HH24:MI') as hora_agendamiento,p.rut_paciente||'-'|| dv_rut_paciente as rut, " +
            " nombre_paciente || ' ' || apaterno_paciente || ' ' || amaterno_paciente as nombre_paciente, " +
            " to_char(fecha_inicio,'dd/MM/yyyy') as fecha_inicio,to_char(fecha_inicio,'HH24:MI') ||'-'|| to_char(fecha_final, 'HH24:MI') as hora,tratamiento," +
            " centro_id_centro, max(em.rut_funcionario) from agenda ag " +
            "join paciente p on ag.rut_paciente = p.rut_paciente join tratamiento t on ag.id_tratamiento = t.id_tratamiento " +
" join equipo_medico em on ag.id_atencion = em.id_atencion join funcionario f on em.rut_funcionario = f.rut_fun where centro_id_centro = '" + idCentro + "' ";
            if (fechaInicio.ToString().Length > 0 && fechaFin.ToString().Length == 0)
            {
                query += "and fecha_inicio between'" + fechaInicio + "' and sysdate";
            }

            if (fechaInicio.ToString().Length > 0 && fechaFin.ToString().Length > 0) //entre ambas fechas
            {
                query += "and fecha_inicio between'" + fechaInicio + "' and '" + fechaFin + "' ";
            }
            if (tratamiento > 0)
            {
                query += "and ag.id_tratamiento =" + tratamiento + "";
            }

            query += " group by ag.id_atencion,fecha_agendamiento,p.rut_paciente,dv_rut_paciente,nombre_paciente,apaterno_paciente,amaterno_paciente," +
                      " centro_id_centro,nombre_paciente,fecha_inicio,fecha_final,tratamiento order by ag.id_atencion desc";
            DataTable dt = oracleTable(query);
            return dt;
        }

        public static void extenderSesion(string id, DateTime fecha)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_AGENDA.EXTENDER_SESION", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id_atencion", OracleDbType.Int32).Value = id;
            comando.Parameters.Add("v_fecha_extension", OracleDbType.Date).Value = fecha;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void finalizarSesion(string id)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_AGENDA.FINALIZAR_SESION", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id_atencion", OracleDbType.Int32).Value = id;
            comando.ExecuteNonQuery();
            c.Close();
        }

        //INSUUUUUUUUUMO

        public static void restarInsumos(string nombre, int cantidad)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("restarInsumos", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = nombre;
            comando.Parameters.Add("v_cantidad", OracleDbType.Int32).Value = cantidad;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void insertarCantidadConsumida(int cantidad, int idins, int idag)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("insertar_cantidad_insumos", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_cantidad", OracleDbType.Int32).Value = cantidad;
            comando.Parameters.Add("v_idI",OracleDbType.Int32).Value = idins;
            comando.Parameters.Add("v_idA", OracleDbType.Int32).Value = idag;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static DataTable obtenerInsumosAdicionales()
        {
            string query = "Select * from insumosAdicionales";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerInsumosPaquete(string id)
        {
            string query = "Select * from insumo where id_paquete ='" + id + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        //Estados

        public static void editarEstadoBox(int id, int idEstado)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("PROCEDIMIENTOS_BOX.CAMBIAR_ESTADO_BOX", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_id", OracleDbType.Int32).Value = id;
            comando.Parameters.Add("v_estado", OracleDbType.Int32).Value = idEstado;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void editarEstadoFuncionarios(int rut1, int rut2, int rut3, int estado)
        {
            OracleCommand comando;
            OracleConnection c = new OracleConnection(ConfigurationManager.AppSettings["Ruta"]);
            c.Open();
            comando = new OracleCommand("cambiarEstadoFuncionarios", c);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("v_rut1", OracleDbType.Int32).Value = rut1;
            comando.Parameters.Add("v_rut2", OracleDbType.Int32).Value = rut2;
            comando.Parameters.Add("v_rut3", OracleDbType.Int32).Value = rut3;
            comando.Parameters.Add("v_id_estado", OracleDbType.Int32).Value = estado;
            comando.ExecuteNonQuery();
            c.Close();
        }

        public static void enviarMail(string correo, string mensaje,string asunto)
        {
          
                string mailPrueba = "edudownprueba@gmail.com";
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                mmsg.To.Add(correo);
                mmsg.Subject = asunto;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Body = mensaje;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.From = new System.Net.Mail.MailAddress(mailPrueba);
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential(mailPrueba, "wenawaton");
                cliente.Port = 25;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";
                cliente.Send(mmsg);
            
            
            
        }

        public static DataTable reporteInsumos(string id)
        {
            string query = "Select * from reporteinsumos where id_atencion = '" + id + "'";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable listarAgendas()
        {
            string query = "Select id_atencion from agenda";
            DataTable tb = oracleTable(query);
            return tb;
        }

        //Consulta Disponibilidad


        public static DataTable obtenerSaludCentro(int idCentro)
        {
            string query = "select rut_fun, apaterno_fun || ' ' || amaterno_fun || ' ' || nombre_fun as nombre from funcionario where activo = 'Y' and CARGO_ID_CARGO in(4,5,6)and centro_id_centro = " + idCentro + "";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerMedicosCentro(int idCentro)
        {

            string query = "select rut_fun ||'-'|| dv_rut_fun as rut, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from medicos where id_estado = 1 and CENTRO_ID_CENTRO = " + idCentro + " order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerKineCentro(int idCentro)
        {

            string query = "select rut_fun ||'-'|| dv_rut_fun as rut, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from KINESIOLOGOS where id_estado = 1 and CENTRO_ID_CENTRO = " + idCentro + " order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerFonoCentro(int idCentro)
        {

            string query = "select rut_fun ||'-'|| dv_rut_fun as rut, apaterno_fun ||' '|| amaterno_fun || ' ' || nombre_fun as nombre from fonoaudiologos where id_estado = 1 and CENTRO_ID_CENTRO = " + idCentro + " order by apaterno_fun";
            DataTable tb = oracleTable(query);
            return tb;
        }

        public static DataTable obtenerInfoProfesional(string rut)
        {

            string query = "select * from REPORTEFUNCIONARIOS where RUT = '" + rut + "'";
            DataTable tb = oracleTable(query);
            return tb;

        }






       
    }
}
