using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultaMVC.Models.DAO;
using ConsultaMVC.Models.DTO;
using ConsultaMVC.Views;


namespace ConsultaMVC.Controllers
{
    class ClientController
    {
        ClientView Vista;
        //Constructor
        public ClientController(ClientView view)
        {
            Vista = view;

            Vista.Load += new EventHandler(ClientList);
            Vista.btnBuscar.Click += new EventHandler(ClientList);
            Vista.txtBuscar.TextChanged += new EventHandler(ClientList);
        }

        private void ClientList(object sender, EventArgs e)
        {
            ClientDao db = new ClientDao();
            Vista.TablaClients.DataSource =
                db.VerRegistros(Vista.txtBuscar.Text);
        }

    }
}
