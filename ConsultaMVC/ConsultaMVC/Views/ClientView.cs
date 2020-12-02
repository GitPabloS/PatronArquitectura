using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaMVC.Controllers;
namespace ConsultaMVC.Views
{
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
            ClientController ctr = new ClientController(this);
        }

    }
}
