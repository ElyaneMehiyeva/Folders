using System;
using System.Collections.Generic;
using System.Text;

namespace _16mart
{
    internal class User
    {
        // Constructor Metod
        public User(string UserName)
        {
            if(!String.IsNullOrWhiteSpace(UserName) && UserName.Length>=6 && UserName.Length <= 25)
            {
                this.UserName = UserName;
            }
        }
        // -----------------
        private string _userName;
        private string _password;    
        // -----------------

        
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    this._userName = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if(value.Length >=8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    this._password = value;                    
                }
            } 
        }
        
       
        // HasDigit Metodu +
        public bool HasDigit(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {                 
                    return true;// tapmasa da false
                }
            }
            return false;
        }
        // HasUpper +
        public bool HasUpper(string text)
        {
            
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsUpper(text[i]))
                {
                    return true;
                }
            } 
            return false;
        }
        // HasLower +
        public bool HasLower(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLower(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        // GetInfo
        public string GetInfo()
        {
            string info = $"UserName : {this._userName} - Password : {this._password}";
            return (info);
        }
       
    } 
}
