using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    internal class ExcluiDados
    {
        Conexao Con = new Conexao();
        SqlCommand Cmd = new SqlCommand();

        public void Excluir(string Nome)
        {
            Cmd.CommandText = "DELETE FROM PESSOA WHERE NOME = @Nome";
            Cmd.Parameters.AddWithValue("@Nome", Nome);

            try
            {
                Cmd.Connection = Con.Conectar();
                Cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Con.Desconectar();
            }
        }
    }
}
