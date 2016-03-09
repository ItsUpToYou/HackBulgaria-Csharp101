using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int DiscountCardId { get; set; }
        public long CreditCardNumber { get; set; }
        public int ZipCode { get; set; }


        public static string CreateHash(string password)
        {
            //Generate a random salt
            RNGCryptoServiceProvider crypt = new RNGCryptoServiceProvider();
            byte[] salt = new byte[32];
            crypt.GetBytes(salt);

            //Hash the password and encode the parameteres
            byte[] hash = PBKDF2(password, salt, 32);
            return Convert.ToBase64String(hash) + ":" + Convert.ToBase64String(salt);
        }
        private static byte[] PBKDF2(string password, byte[] salt, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            return pbkdf2.GetBytes(outputBytes);
        }
    }
}
