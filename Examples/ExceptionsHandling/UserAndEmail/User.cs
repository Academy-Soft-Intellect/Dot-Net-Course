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

        public User(string email, string pass)
        {
            this.Email = email;
            this.Password = pass;
        }


        private bool CheckPassword(string pass)
        {
            if (pass.Length >= 6)
            {
                foreach (char symbol in pass)
                {
                    if (char.IsDigit(symbol))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private bool CheckEmail(string email)
        {
            if (email.Length < 5)
            {
                return false;
            }
            if (!email.Contains('@'))
            {
                return false;
            }
            if (!email.Contains('.'))
            {
                return false;
            }
            return true;
        }
    }
}
