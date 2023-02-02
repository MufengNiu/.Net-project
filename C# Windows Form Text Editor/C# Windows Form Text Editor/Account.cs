using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Account
    {
        private string username;
        private string password;
        private string usertype;
        private string firstname;
        private string lastname;
        private string dateOfBirth;


        public Account(String username , String password , String usertype , String firstname, String lastname , String dateOfBirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.usertype = usertype;
            this.dateOfBirth = dateOfBirth;
        }

        public Account(){}
      
        // Store new registered account into the login file
        public Boolean storeAccount()
        {
            String newInput = username + "," + password + "," +
                                usertype + "," + firstname + "," +
                                lastname + "," + dateOfBirth;
            try
            {
                File.AppendAllText("login.txt", newInput + Environment.NewLine);

            }catch (Exception)
            {
                return false;
            }

            return true;
        }

        public String getUsername()
        {
            return this.username;
        }
    
        public String getUsertype()
        {
            return this.usertype;
        }

        public String getname()
        {
            return this.firstname + " " + this.lastname;
        }

        public String getPassword()
        {
            return this.password;
        }
    }
}
