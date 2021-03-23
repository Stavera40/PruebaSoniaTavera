using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Datos
{
    public class MetodosDatos
    {
        public static NpgsqlCommand CrearComando()
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = Configuracion.CadenaConexion;
            NpgsqlCommand Com = new NpgsqlCommand();
            Com = con.CreateCommand();
            Com.CommandType = CommandType.Text;
            return Com;
        }
        public static DataTable EjecutarComandoSelect(NpgsqlCommand Com)
        {
            DataTable dt = new DataTable();
            try
            {
                Com.Connection.Open();
                NpgsqlDataAdapter Adp = new NpgsqlDataAdapter();
                Adp.SelectCommand = Com;
                Adp.Fill(dt);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                Com.Connection.Close();
            }
            return dt;
        }
    }
}
