using modelfor_archive.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace modeforview2.Models
{
    public partial class ListUserMes
    {
        public int UserId { get; set; }
        public int MessageId { get; set; }

        public virtual Message Message { get; set; }
        public virtual UserAcc User { get; set; }
    }
}