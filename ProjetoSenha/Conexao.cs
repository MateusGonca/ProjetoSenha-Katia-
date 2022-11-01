using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenha
{
    public  class Conexao
    {
        public MySqlConnection conecta; 

        public void Conectar()
        {
            if (conecta.State == ConnectionState.Closed)
            {
                conecta.ConnectionString = "Server=localhost;Database=db_senha;User=root;Pwd=cursoads";
                conecta.Open();
            }
        }
        public void Desconectar()
        {
            if (conecta.State == ConnectionState.Open)
            {
                conecta.Close();
            }
        }
        public int ExecSql(string sql)
        {

            int nlinhas;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;
                nlinhas = comando.ExecuteNonQuery();
            } catch (Exception ex)
            {
                Console.WriteLine("Erro: = ex");
                nlinhas = 0;
            }
            return nlinhas;
        }
    }
}
