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
        string conect = "SERVER=localhost; DATABASE=hotel; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;

        public void abrirCon()
        {

        }

        public void fecharCon() 
        { 
        
        }
    }
}
