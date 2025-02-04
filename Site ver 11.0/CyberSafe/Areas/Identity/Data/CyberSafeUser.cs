﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Construction;

namespace CyberSafe.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CyberSafeUser class
public class CyberSafeUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}