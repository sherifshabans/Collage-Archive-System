using System;
using System.Collections.Generic;

#nullable disable

namespace modelfor_archive.Models
{
    public partial class Message
    {
        public Message()
        {
            Attachments = new HashSet<Attachment>();
        }

        public int MessageId { get; set; }
        public bool? Rcv { get; set; }
        public string Title { get; set; }
        public string MessageText { get; set; }
        public DateTime? RcvTime { get; set; }
        public bool? Seen { get; set; }
        public DateTime? SendDate { get; set; }
        public int? UserId { get; set; }

        public virtual UserAcc User { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }

    public class test
    {

    }
}