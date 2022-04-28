using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    public class Cadastro
    {
        Conexao Con = new Conexao();
        SqlCommand Cmd = new SqlCommand();
        public string Mensagem = "";

        public Cadastro(string Nome)
        {
            Cmd.CommandText = "INSERT INTO PESSOA (NOME) VALUES(@Nome)";

            Cmd.Parameters.AddWithValue("@Nome", Nome);
            try
            {
                Cmd.Connection = Con.Conectar();
                
                Cmd.ExecuteNonQuery();
                
                Con.Desconectar();

                this.Mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException ex)
            {
                this.Mensagem = "Erro ao se conectar com banco de dados";
            }
        }
    }
}
