using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Persistence.Models
{
    public class AppUser : IdentityUser
    {
        public string? NombreCompleto { get; set; }
        public string? Carrera { get; set; }
    }
}
