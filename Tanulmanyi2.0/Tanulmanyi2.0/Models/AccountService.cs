using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tanulmanyi2._0.Models
{
    public class AccountService : IAccountService
    {
        private readonly TanulmanyiContext _context;

        public AccountService(TanulmanyiContext context)
        {
            _context = context;
        }

        public Student GetStudent(string userName)
        {
            if (userName == null)
                return null;

            return _context.Students.FirstOrDefault(c => c.UserName == userName); // megkeressük a vendéget
        }

        public Boolean Login(LoginViewModel user)
        {
            if (user == null)
                return false;

            // ellenőrizzük az annotációkat
            if (!Validator.TryValidateObject(user, new ValidationContext(user, null, null), null))
                return false;

            Student student = _context.Students.FirstOrDefault(c => c.UserName == user.UserName); // megkeressük a felhasználót

            if (student == null)
                return false;

            // ellenőrizzük a jelszót (ehhez a kapott jelszót hash-eljük)
            Byte[] passwordBytes = null;
            using (SHA512CryptoServiceProvider provider = new SHA512CryptoServiceProvider())
            {
                passwordBytes = provider.ComputeHash(Encoding.UTF8.GetBytes(user.UserPassword));
            }

            if (!passwordBytes.SequenceEqual(student.Password))
                return false;

            return true;
        }

        public Boolean Logout()
        {
            return true;
        }
    }
}
