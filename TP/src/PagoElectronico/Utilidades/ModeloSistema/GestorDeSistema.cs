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
    }
}
