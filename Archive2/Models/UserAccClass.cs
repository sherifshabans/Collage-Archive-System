using modeforview2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace modelfor_archive.Models
{
    public partial class UserAcc
    {
        public UserAcc()
        {
            Messages = new HashSet<Message>();
        }

        [Key]
        public int UserAccID { get; set; }
        public string UserName { get; set; }
        public string AcadMail { get; set; }
        public string Pass { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }


    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}