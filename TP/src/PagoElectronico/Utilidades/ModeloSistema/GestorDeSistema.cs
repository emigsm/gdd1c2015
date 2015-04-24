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

        public static int loginUsuario(string usuario, string contrasena)
        {
            int usuario_ID;
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter user = new SqlParameter("@usuario", usuario);
            SqlParameter pass = new SqlParameter("@pass", contrasena);
            parametros.Add(user);
            parametros.Add(pass);
            object resultadoStoreProcedure = ConexionDB.ConexionDB.InvocarStoreProcedure(STORE_LOGINUSUARIO, SCALAR, parametros);
            usuario_ID = ((resultadoStoreProcedure != null) ? Convert.ToInt32(resultadoStoreProcedure) : 0);
            return usuario_ID;
        }
    }
}
