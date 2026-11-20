using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        SqlConnection conexion;
        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TpGenerala;Integrated Security=True"; ;
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }
        private SqlCommand CrearComando(string sql, List<SqlParameter>parametros = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sql;

            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray()); 
            }
            return cmd;
        }
        public int Escribir(string sql, List<SqlParameter>parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int filas = 0;

            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                filas = -1;
            }

            cmd.Parameters.Clear();
            cmd.Dispose();
            cmd = null;

            return filas;
        }
        public SqlDataReader Leer(string sql, List<SqlParameter>parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int LeerEscalar(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int res = 0;
            try
            {
                res = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                res = -1;
            }
            cmd.Parameters.Clear();
            cmd.Dispose();
            cmd = null;
            return res;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, bool valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Boolean;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.DateTime;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, object valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            return parametro;
        }
    }
}
