using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Simples
{
    public class MostraDados
    {
        Conexao Con = new Conexao();
        SqlCommand Cmd = new SqlCommand();

       //código sem SqlAdapter
       /* public string Mostrar(string Nome)
        {
            string Resultado = null;
            Cmd.CommandText = "SELECT NOME FROM PESSOA WHERE NOME = @Nome";
            Cmd.Parameters.AddWithValue("@Nome", Nome);

            try
            {

               Cmd.Connection = Con.Conectar();
               SqlDataReader Rd = Cmd.ExecuteReader();
                if (Rd.Read())
                {
                    Resultado = Rd[0].ToString();
                } 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Con.Desconectar();
            }
            return Resultado;
        }*/
        
        public DataTable Mostrar()
        {

            DataTable Resultado = new DataTable();
            Cmd.CommandText = "SELECT NOME FROM PESSOA";
            
            try
            {
                Cmd.Connection = Con.Conectar();

                SqlDataAdapter Adapter = new SqlDataAdapter(Cmd);

                Adapter.Fill(Resultado);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Con.Desconectar();
            }
            return Resultado;
        }
        public DataTable Mostrar(string Nome)
        {

            DataTable Resultado = new DataTable();
            Cmd.CommandText = "SELECT NOME FROM PESSOA WHERE NOME = @NOME";
            Cmd.Parameters.AddWithValue("@Nome",Nome);
            Cmd.Connection = Con.Conectar();
            try
            {

                SqlDataAdapter Adapter = new SqlDataAdapter(Cmd);

                Adapter.Fill(Resultado);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Con.Desconectar();
            }
            return Resultado;
        }

    }
}
