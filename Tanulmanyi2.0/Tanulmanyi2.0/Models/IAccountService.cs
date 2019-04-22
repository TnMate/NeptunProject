using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tanulmanyi2._0.Models
{
    public interface IAccountService
    {
        Student GetStudent(string userName);

        Boolean Login(LoginViewModel user);

        Boolean Logout();
    }
}
