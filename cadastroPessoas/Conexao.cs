using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroPessoas
{
   public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //CONSTRUTOR
        // pra que o construtor então?
        // nao tinha visto perae
        // roda para ei ver o rrro
        public Conexao()
        {
            con.ConnectionString = "Data Source=DESKTOP-VVSDPQ8;Initial Catalog=cadastro;Integrated Security=True";
        }
        //METODO CONECTAR
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //METODO DESCONECTAR
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
        }

    }
}
