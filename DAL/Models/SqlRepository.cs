using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using  System.Data;
using System.Text;

namespace DAL.Models
{
    public class SqlRepository
    {
        private string conn;
        private SqlConnection sqlConn;
        public SqlRepository(string sqlConnString)
        {
            conn = sqlConnString;
        }

        public List<Pracownik> Pracownicy()
        {
            List<Pracownik> lista = new List<Pracownik>();
            using (sqlConn = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM Pracownicy";
                SqlCommand cmd = new SqlCommand(sql,sqlConn);
                sqlConn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(
                        new Pracownik()
                        {
                            ID = reader.GetInt32(0),
                            Imie = reader.GetString(1),
                            Nazwisko = reader.GetString(2),
                            Pensja = reader.GetDecimal(3),
                            StanowiskoID = reader.GetInt32(4)
                        }
                    );
                }
            }
            return lista;
        }
    }
}
