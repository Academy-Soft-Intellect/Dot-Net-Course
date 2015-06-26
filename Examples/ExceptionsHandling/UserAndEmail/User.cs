using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndEmail
{
    public class User
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {

                if (CheckEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new EmailException("Invalid email");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (CheckPassword(value))
                {
                    this.password = value;
                }
                else
                {
                    throw new PasswordException("Invalid password");
                }

            }
        }

        public User()
        {

        }

        public User(string email, string pass)
        {
        }


        private bool CheckPassword(string pass)
        {
            if (pass.Length >= 6)
            {
                bool containsDigit = false;
                foreach (char symbol in pass)
                {
                    if (char.IsDigit(symbol))
                    {
                        containsDigit = true;
                    }
                }
                if (containsDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool CheckEmail(string email)
        {
            if (email.Length > 5 && email.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
