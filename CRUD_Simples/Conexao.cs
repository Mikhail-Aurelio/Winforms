using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    public class Conexao
    {
        SqlConnection Con = new SqlConnection();

        public Conexao()
        {
            
          Con.ConnectionString = @"Data Source=LAPTOP-8FVVIA2M\SQLEXPRESS;Initial Catalog=Cliente;Integrated Security=True";

        }

        public string ConString()
        {
            return Con.ConnectionString;
        }
        public SqlConnection Conectar()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            return Con;
        }
        public void Desconectar()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}
