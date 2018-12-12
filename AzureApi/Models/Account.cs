using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AzureApi.Models
{
    
    public class Account
    {
        private readonly MD5 _algorith = MD5.Create();

        public Account()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = StatusAt.Active;
        }

        public long Id { get; set; }

        public string User { get; set; }

        public string PassWord { get; set; }

        public string Salt { get; set; }

        public StatusAt Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public enum StatusAt
        {
            Active = 1,
            DeActive = 0,
        }

        public void GenerateSalt()
        {
            this.Salt = Guid.NewGuid().ToString();
        }

        public void EncryptPassword()
        {
            this.PassWord += this.Salt;
            var algorithm = MD5.Create();
            var hashPassword = algorithm.ComputeHash(Encoding.UTF8.GetBytes(this.PassWord));
            this.PassWord = Convert.ToBase64String(hashPassword);
        }

        public string EncryptString(string stringToEncrypt)
        {
            var hash = _algorith.ComputeHash(Encoding.UTF8.GetBytes(stringToEncrypt));
            return Convert.ToBase64String(hash);

        }

        public bool CheckLoginPassword(string loginPassword)
        {
            loginPassword += this.Salt;
            loginPassword = EncryptString(loginPassword);
            return loginPassword == this.PassWord;
        }

    }
}
