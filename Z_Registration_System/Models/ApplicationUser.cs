using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z_Registration_System.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
    }
}
