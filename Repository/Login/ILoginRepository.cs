using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TCC.Database;

namespace TCC.Repository.Login
{
    public interface ILoginRepository
    {
        String validarLogin (IdentityUser login);
    }
}