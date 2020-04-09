using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroPessoas
{
    public class Cadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem;
        public Cadastro(String nome, String telefone)
        {
            //Comando Sql instanciar SqlCommand (insert, update, delte)
            cmd.CommandText = "INSERT INTO cadastroPessoas (nome, telefone) values (@nome, @telefone)";

            //parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            //conectar com banco instanciar conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando 
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso -- variavel string mensagem
                this.mensagem = "Cadastrado com sucesso!";

            }
            catch (Exception e)
            {

                this.mensagem = "Erro ao tentar comunicar com o banco de dados";
            }
            
            
            
        }
    }
}
