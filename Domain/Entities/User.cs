using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string? Avatar { get; set; }
    public bool? Gender { get; set; }
    public string? Email { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated {  get; set; }
}
