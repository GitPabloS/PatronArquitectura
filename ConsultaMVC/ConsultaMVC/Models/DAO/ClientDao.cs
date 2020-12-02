using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ConsultaMVC.Models.DTO;


namespace ConsultaMVC.Models.DAO
{
    class ClientDao:DbContext
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        //Metodos CRUD
        public List<Client> VerRegistros(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);
            Conexion.Open();
            LeerFilas = Comando.ExecuteReader();
            //DTO
            //Lista generica 
            List<Client> ListaGenerica = new List<Client>();
            //Diccionario
            //Serializacion- XML, JSON, Nativa 
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Client
                {
                    ID = LeerFilas.GetInt32(0),
                    Name = LeerFilas.GetString(1),
                    LastName = LeerFilas.GetString(2),
                    Direction = LeerFilas.GetString(3),
                    City = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Phone = LeerFilas.GetString(6),
                    Ocupation = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

        public void Insert() { }
        public void Edit() { }
        public void Delete() { }
    }
}
