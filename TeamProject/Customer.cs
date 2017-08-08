using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
   public class Customer
    {
        private int customerID;
        private string lastName;
        private string firstName;
        private string prefix;
        private string gender;
        private string address;
        private string city;
        private string state;
        private int zip;
        private string phone;
        private string email;


        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value;}
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public Customer()
        {


        }


    }
}

