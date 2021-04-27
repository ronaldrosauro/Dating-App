using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
