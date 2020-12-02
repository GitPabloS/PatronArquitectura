using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaMVC.Models.DTO
{
    class Client
    {
        int _ID;
        string _Name;
        string _LastName;
        string _Direction;
        string _City;
        string _Email;
        string _Phone;
        string _Ocupation;
        //PROPIEDADES GETTERS AND SETTERS
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string Direction
        {
            get
            {
                return _Direction;
            }

            set
            {
                _Direction = value;
            }
        }

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public string Ocupation
        {
            get
            {
                return _Ocupation;
            }

            set
            {
                _Ocupation = value;
            }
        }
    }
}
