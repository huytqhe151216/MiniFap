using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace MiniFap.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName1{get;set;}
    }
}
