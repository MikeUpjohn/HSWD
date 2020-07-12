using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace artefact
{
    public class Password
    {
        private string password;
        private Random random = new Random();

        /// <summary>
        /// Password Property
        /// </summary>
        public string PassWord
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Password()
        {

        }

        /// <summary>
        /// Password constructor.
        /// </summary>
        /// <param name="password">The password.</param>
        public Password(string password)
        {
            this.PassWord = password;
        }

        /// <summary>
        /// Hashes a users password for secure storage. With thanks to http://blogs.msdn.com/b/csharpfaq/archive/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string_3f00_.aspx
        /// </summary>
        public void HashPassword()
        {
            if (this.PassWord != null)
            {
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(this.PassWord);
                byte[] hash = md5.ComputeHash(inputBytes);

                StringBuilder hashedPassword = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    hashedPassword.Append(hash[i].ToString("X2"));
                }

                this.PassWord = hashedPassword.ToString();
            }
            else
            {
                throw new Exception("Error 2001: You cannot encrypt a password that has not been set.");
            }
        }

        /// <summary>
        /// Generate a temporary eight character password for a user, whenever they choose to reset their password.
        /// </summary>
        public void GenerateTemporaryPassword()
        {
            string allowedCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string password = "";

            for (int i = 0; i < 8; i++)
            {
                password += allowedCharacters[random.Next(0, allowedCharacters.Length)].ToString();
            }

            this.PassWord = password;
        }
    }
}