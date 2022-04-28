using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    internal class AtualizaDados
    {
        Conexao Con = new Conexao();
        SqlCommand Cmd = new SqlCommand();

        public void Atualizar(string Nome, string NomeNovo)
        {
            Cmd.CommandText = "UPDATE PESSOA SET NOME = @NomeNovo WHERE NOME = @Nome";
            Cmd.Parameters.AddWithValue("@NomeNovo", NomeNovo);
            Cmd.Parameters.AddWithValue("@Nome", Nome);

            try
            {
                Cmd.Connection = Con.Conectar();
                Cmd.ExecuteNonQuery();

            }catch (SqlException ex)
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
