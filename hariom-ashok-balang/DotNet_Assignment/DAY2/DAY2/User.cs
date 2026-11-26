using System;
namespace DAY2
{
    internal class User
    {
        private string _username;
        private string _password;
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public void SetPassword(string password)
        {
            _password = password;
        }
        public bool ValidatePassword(string inputPassword)
        {
            return _password == inputPassword;
        }
    }
}