using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

using PagoElectronico.Utilidades.Cifrado;
using PagoElectronico.Utilidades.ConexionDB;

namespace PagoElectronico.Utilidades.ModeloSistema
{
    class GestorDeSistema
    {
        //Declaración de constantes
        private const int NONQUERY = 1;
        private const int READER = 2;
        private const int SCALAR = 3;

        //Constantes de StoreProcedure
        private const string STORE_LOGINUSUARIO = "GEM4.spLoginUsuario";
        private const string STORE_CANTIDADROLES = "GEM4.spCantidadRoles";
        private const string STORE_OBTENERROLES = "GEM4.spObtenerRoles";
        private const string STORE_OBTENERFUNCIONALIDADES = "GEM4.spObtenerFuncionalidades";
        private const string STORE_INHABILITARUSUARIO = "GEM4.spInhabilitarUsuario";
        private const string STORE_BUSCARROLES = "GEM4.spBuscarRoles";
        private const string STORE_LOGLOGIN = "GEM4.spLogLogin";
        private const string STORE_OBTENERDATOSUSUARIO = "GEM4.spObtenerDatosUsuario";
        private const string STORE_BAJALOGICAUSUARIO = "GEM4.spBajaLogicaUsuario";
        private const string STORE_OBTENERFUNCIONALIDADESASIGNABLES = "GEM4.spObtenerFuncionalidadesAsignables";
        private const string STORE_CREARROL = "GEM4.spCrearRol";
        private const string STORE_AGREGARFUNCIONALIDADAROL = "GEM4.spAgregarFuncionalidadARol";
        private const string STORE_CAMBIARHABILITACIONUSUARIO = "GEM4.spCambiarHabilitacionUsuario";
        private const string STORE_CAMBIARCONTRASEÑA = "GEM4.spCambiarContraseña";
        private const string STORE_CAMBIARPREGUNTASECRETA = "GEM4.spCambiarPreguntaSecreta";
        private const string STORE_OBTENERROLESUSUARIO = "GEM4.spObtenerRolesParaUsuario";
        private const string STORE_AGREGARROLAUSUARIO = "GEM4.spAgregarRolAUsuario";
        private const string STORE_MODIFICARROLAUSUARIO = "GEM4.spModificarRolAUsuario";
        private const string STORE_ELIMINARROLAUSUARIO = "GEM4.spEliminarRolAUsuario";
        private const string STORE_ALTAUSUARIO = "GEM4.spAltaUsuario";
        private const string STORE_USUARIOEXISTE = "GEM4.spUsuarioExiste";
        private const string STORE_OBTENERDATOSCUENTA = "GEM4.spObtenerDatosCuenta";
        private const string STORE_HABILITARODESHABILITARROL = "GEM4.sphabilitarODeshabilitarRol";
        private const string STORE_OBTENERNUMEROCLIENTE = "GEM4.spObtenerNumeroCliente";
        private const string STORE_OBTENERPAISES = "GEM4.spObtenerPaises";
        private const string STORE_OBTENERMONEDAS = "GEM4.spObtenerMonedas";
        private const string STORE_OBTENERTIPOCUENTAS = "GEM4.spObtenerTipoCuentas";
        private const string STORE_ALTACUENTA = "GEM4.spAltaCuenta";
        private const string STORE_BUSCARCLIENTES = "GEM4.spBuscarClientes";
        private const string STORE_OBTENERTIPODOCS = "GEM4.spObtenerTiposDoc";
        private const string STORE_OBTENERFUNCIONESHABILITADASPORROL = "GEM4.spObtenerFuncionesHabilitadasPorRol";
        private const string STORE_OBTENERTARJETASCLIENTE = "GEM4.spObtenerTarjetasCliente";
        private const string STORE_MODIFICARNOMBREROL = "GEM4.spModificarNombreRol";

        public static int loginUsuario(string usuario, string contrasena)
        {
            int Rol_Cod;
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter user = new SqlParameter("@usuario", usuario);
            SqlParameter pass = new SqlParameter("@pass", contrasena);
            parametros.Add(user);
            parametros.Add(pass);
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_LOGINUSUARIO, SCALAR, parametros);
            Rol_Cod = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return Rol_Cod;
        }

        public static int cantidadRoles(string usuario)
        {
            int cantidadRoles;
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter user = new SqlParameter("@usuario", usuario);
            parametros.Add(user);
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_CANTIDADROLES, SCALAR, parametros);
            cantidadRoles = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return cantidadRoles;

        }

        public static DataTable obtenerRoles()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerRoles = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERROLES, READER, parametros);
            DataTable roles = new DataTable();
            if (readerRoles.HasRows)
            {
                roles.Load(readerRoles);
            }
            readerRoles.Dispose();
            return roles;
        }

        public static DataTable obtenerFuncionalidades(int rolCod)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@rol_cod", rolCod));
            SqlDataReader readerFuncionalidades = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERFUNCIONALIDADES, READER, parametros);
            DataTable funcionalidades = new DataTable();
            if (readerFuncionalidades.HasRows)
            {
                funcionalidades.Load(readerFuncionalidades);
            }
            readerFuncionalidades.Dispose();
            return funcionalidades;
        }

        public static void inhabilitarUsuario (string username)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@username", username));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_INHABILITARUSUARIO, NONQUERY, parametros);
        }

        public static void logLogin(string username, bool incorrecto, int nIntento)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@username", username));
            parametros.Add(new SqlParameter("@incorrecto", incorrecto));
            parametros.Add(new SqlParameter("@nIntento", nIntento));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_LOGLOGIN, NONQUERY, parametros);
        }

         //ABM ROL


        internal static DataTable buscarRoles(string rol_cod, string rol_nombre)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@rol_cod", rol_cod));
            parametros.Add(new SqlParameter("@rol_nombre", rol_nombre));
            SqlDataReader readerRoles = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_BUSCARROLES, READER, parametros);
            DataTable roles = new DataTable();
            if (readerRoles.HasRows)
            {
                roles.Load(readerRoles);
            }
            readerRoles.Dispose();
            return roles;
        }

        public static DataTable obtenerDatosUsuario(string username)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@username", username));
            SqlDataReader readerUsuarios = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERDATOSUSUARIO, READER, parametros);
            DataTable usuarios = new DataTable();
            if (readerUsuarios.HasRows)
            {
                usuarios.Load(readerUsuarios);
            }
            readerUsuarios.Dispose();
            return usuarios;
        }

        public static void bajaLogicaUsuario(int usuarioID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_BAJALOGICAUSUARIO, NONQUERY, parametros);
        }

        public static DataTable obtenerFuncionalidadesAsignables()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerFuncionalidades = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERFUNCIONALIDADESASIGNABLES, READER, parametros);
            DataTable funcionalidades = new DataTable();
            if (readerFuncionalidades.HasRows)
            {
                funcionalidades.Load(readerFuncionalidades);
            }
            readerFuncionalidades.Dispose();
            return funcionalidades;
        }

        public static void crearRol(string Rol_Nombre,bool Rol_Habilitado)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Rol_Nombre", Rol_Nombre));
            parametros.Add(new SqlParameter("@Rol_Habilitado", Rol_Habilitado));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_CREARROL, NONQUERY, parametros);
        }
        public static void agregarFuncionalidadARol(string Rol_Nombre,int Funcionalidad_Cod,int Funcionalidad_Hab)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Rol_Nombre", Rol_Nombre));
            parametros.Add(new SqlParameter("@Funcionalidad_Cod", Funcionalidad_Cod));
            parametros.Add(new SqlParameter("@Funcionalidad_Hab", Funcionalidad_Hab));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_AGREGARFUNCIONALIDADAROL, NONQUERY, parametros);
        }

        public static void cambiarHabilitacionUsuario(bool estado, int usuarioID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@estado", estado));
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_CAMBIARHABILITACIONUSUARIO, NONQUERY, parametros);
        }

        public static void cambiarContraseña(int usuarioID, string contraseña)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            parametros.Add(new SqlParameter("@nuevaPass", contraseña));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_CAMBIARCONTRASEÑA, NONQUERY, parametros);
        }

        public static void cambiarPreguntaSecreta(int usuarioID, string preguntaSec, string respuestaSec)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            parametros.Add(new SqlParameter("@nuevaPreg", preguntaSec));
            parametros.Add(new SqlParameter("@nuevaResp", respuestaSec));

            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_CAMBIARPREGUNTASECRETA, NONQUERY, parametros);
        }

        public static DataTable obtenerRolesParaUsuario(int usuarioID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            SqlDataReader readerRoles = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERROLESUSUARIO, READER, parametros);
            DataTable roles = new DataTable();
            if (readerRoles.HasRows)
            {
                roles.Load(readerRoles);
            }
            readerRoles.Dispose();
            return roles;
        }

        public static void agregarRolAUsuario(int usuarioID, int rolCod)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            parametros.Add(new SqlParameter("@rolCod", rolCod));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_AGREGARROLAUSUARIO, NONQUERY, parametros);
        }

        public static void modificarRolAUsuario(int usuarioID, int nuevoRolCod, int viejoRolCod)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            parametros.Add(new SqlParameter("@nuevoRolCod", nuevoRolCod));
            parametros.Add(new SqlParameter("@viejoRolCod", viejoRolCod));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_MODIFICARROLAUSUARIO, NONQUERY, parametros);
        }

        public static void eliminarRolAUsuario(int usuarioID, int rolCod)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@usuarioID", usuarioID));
            parametros.Add(new SqlParameter("@rolCod", rolCod));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_ELIMINARROLAUSUARIO, NONQUERY, parametros);
        }

        public static void altaUsuario(string username, string contraseña, int rolCod, string pregSec, string respSec)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@username", username));
            parametros.Add(new SqlParameter("@contraseña", contraseña));
            parametros.Add(new SqlParameter("@rolCod", rolCod));
            parametros.Add(new SqlParameter("@pregSec", pregSec));
            parametros.Add(new SqlParameter("@respSec", respSec));
            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_ALTAUSUARIO, NONQUERY, parametros);
        }

        public static bool usuarioExiste(string usuario)
        {
            int existe;
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter user = new SqlParameter("@username", usuario);
            parametros.Add(user);
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_USUARIOEXISTE, SCALAR, parametros);
            existe = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return Convert.ToBoolean(existe);

        }

        public static DataTable obtenerDatosCuenta(string numeroCuenta, string clienteID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@numeroCuenta", numeroCuenta));
            parametros.Add(new SqlParameter("@clienteID", clienteID));
            SqlDataReader readerDatosCuenta = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERDATOSCUENTA, READER, parametros);
            DataTable datosCuenta = new DataTable();
            if (readerDatosCuenta.HasRows)
            {
                datosCuenta.Load(readerDatosCuenta);
            }
            readerDatosCuenta.Dispose();
            return datosCuenta;
        }

        public static void habilitarODeshabilitarRol(int rolCod, byte rolHabilitado)
        {
            List<SqlParameter> parametrosStore = new List<SqlParameter>();
            parametrosStore.Add(new SqlParameter("@Rol_Cod", rolCod));
            parametrosStore.Add(new SqlParameter("@Rol_Habilitado", rolHabilitado));

            ConexionDB.ConexionDB.InvocarStoreProcedure("GEM4.sphabilitarODeshabilitarRol", NONQUERY, parametrosStore);
        }

        public static int obtenerNumeroCliente(string username)
        {
            int numeroCliente;
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter user = new SqlParameter("@username", username);
            parametros.Add(user);
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERNUMEROCLIENTE, SCALAR, parametros);
            numeroCliente = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return numeroCliente;

        }

        public static DataTable obtenerPaises()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerPaises = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERPAISES, READER, parametros);
            DataTable paises = new DataTable();
            if (readerPaises.HasRows)
            {
                paises.Load(readerPaises);
            }
            readerPaises.Dispose();
            return paises;
        }

        public static DataTable obtenerMonedas()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerMonedas = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERMONEDAS, READER, parametros);
            DataTable monedas = new DataTable();
            if (readerMonedas.HasRows)
            {
                monedas.Load(readerMonedas);
            }
            readerMonedas.Dispose();
            return monedas;
        }

        public static DataTable obtenerTipoCuentas()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlDataReader readerTipoCuentas = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERTIPOCUENTAS, READER, parametros);
            DataTable tipoCuentas = new DataTable();
            if (readerTipoCuentas.HasRows)
            {
                tipoCuentas.Load(readerTipoCuentas);
            }
            readerTipoCuentas.Dispose();
            return tipoCuentas;
        }

        public static int altaCuenta(string clienteID, int codPais, int codMoneda, int tipoCuenta)
        {
            int numeroCuenta;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@clienteID", clienteID));
            parametros.Add(new SqlParameter("@codPais", codPais));
            parametros.Add(new SqlParameter("@codMoneda", codMoneda));
            parametros.Add(new SqlParameter("@tipoCuenta", tipoCuenta));
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_ALTACUENTA, NONQUERY, parametros);
            numeroCuenta = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return numeroCuenta;
        }

        public static DataTable buscarClientes(string nombre, string apellido, string tipoDoc, string nroDoc, string mail)
        {

            

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@nombreCliente", nombre));
            parametros.Add(new SqlParameter("@apellidoCliente",apellido));
            parametros.Add(new SqlParameter("@tipoDoc",tipoDoc));
            parametros.Add(new SqlParameter("@nroDoc", nroDoc));
            parametros.Add(new SqlParameter("@mail", mail));
            SqlDataReader readerClientes = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_BUSCARCLIENTES, READER, parametros);
            DataTable clientes=new DataTable();
            if (readerClientes.HasRows)
            {
                clientes.Load(readerClientes);
            }
            readerClientes.Dispose();
            return clientes;
        }


        public static DataTable obtenerTarjetasCliente(Int32 clienteID)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("ClienteID",clienteID));
            SqlDataReader readerTarjetas= (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERTARJETASCLIENTE,READER,parametros);
            DataTable tarjetas=new DataTable();
            if(readerTarjetas.HasRows)
            {
                tarjetas.Load(readerTarjetas);
            }
            readerTarjetas.Dispose();
            return tarjetas;
        }

        public static DataTable obtenerTiposDoc()
        {
            SqlDataReader readerTiposDoc = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERTIPODOCS, READER, null);
            DataTable tiposDoc=new DataTable();
            if (readerTiposDoc.HasRows)
            {
                tiposDoc.Load(readerTiposDoc);
            }
            readerTiposDoc.Dispose();
            return tiposDoc;
        }

        internal static List<byte> obtenerFuncionesHabilitadasPorRol(int codigo_rol)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@rol_cod", codigo_rol));

            SqlDataReader readerroles = (SqlDataReader)ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_OBTENERFUNCIONESHABILITADASPORROL, READER, parametros);
            List<byte> lista = new List<byte>();
            while (readerroles.Read())
                lista.Add((byte)readerroles["Funcionalidad_Cod"]);
            readerroles.Dispose();
            return lista;
        }

        public static void modificarNombreRol(int rolCod, string rolNombre)
        {
            List<SqlParameter> parametrosStore = new List<SqlParameter>();
            parametrosStore.Add(new SqlParameter("@Rol_Cod", rolCod));
            parametrosStore.Add(new SqlParameter("@Rol_Nombre", rolNombre));

            ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_MODIFICARNOMBREROL, NONQUERY, parametrosStore);
        }
    }
}