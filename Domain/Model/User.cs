﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class User : IdentityUser<Guid>
    {
        public ShowContacts SawContacts { get; set; }
    }
}
