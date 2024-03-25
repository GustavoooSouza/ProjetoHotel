using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel
{
    internal class Conexao
    {
        //CONEXAO COM BANCO DE DADOS LOCAL
        string conect = "SERVER=localhost; DATABASE=hotel; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;

        public void abrirCon()
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharCon() 
        {
            try
            {
                con = new MySqlConnection(conect);
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //DECLARAO DE OUTRAS VARIAVEIS
    }
}
