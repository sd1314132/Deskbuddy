using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deskbuddy.Models;
using Microsoft.AspNetCore.Identity;

namespace Deskbuddy.Areas.Identity.Data;

public class DeskbuddyUser : IdentityUser
{
    public ICollection<Occupancy> Occupancies { get; set; } = new List<Occupancy>();
}

