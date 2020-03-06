using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TIND_4S
{
    public class ClsConexao
    {
        public SqlConnection conexao = new SqlConnection();
        //public SqlTransaction transaction = new SqlTransaction();

        public SqlConnection conectar()
        {
            desconectar();
            //conexao.ConnectionString = "Server = INFORMATICA14; Database = db_Teste; Uid = sa; Pwd = tindifsp;";            
            //conexao.ConnectionString = "Server = GH-PC; Database = db_TIND_IFSP; Uid = tindifsp; Trusted_Connection=True;";
            //conexao.ConnectionString = @"Persist Security Info=False; Server=localhost; Database=db_Tind4S; Integrated Security=true; MultipleActiveResultSets=true;";
            //conexao.ConnectionString = "Server = IBM-PC\\SQLEXPRESS; Database = db_Tind4S; Uid = userTind4s; Trusted_Connection=True;";
            conexao.ConnectionString = "Server = db-tind4s.chwaokuky6hn.sa-east-1.rds.amazonaws.com, 1433; Database = db_Tind4S; Uid = adminTind4S; Pwd = mineirofoda;";
            //conexao.ConnectionString = "Server = IBM-PC\\SQLEXPRESS; Database = db_Tind4S; Uid = userTind4s; Trusted_Connection=True;";
            //conexao.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename= |DataDirectory|\BancoDeDados.mdf;Integrated Security=True";
            conexao.Open();
            return conexao;
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
