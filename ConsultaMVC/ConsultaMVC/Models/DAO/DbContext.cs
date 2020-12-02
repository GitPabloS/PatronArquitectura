using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsultaMVC.Models.DAO
{
    public class DbContext
    {
        protected SqlConnection Conexion = new SqlConnection(
            "Server=LAPTOP-PEHQVPE3;DataBase=Practica_Patrones;Integrated Security=true");
    }
}
