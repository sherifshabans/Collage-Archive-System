using System;
using System.Collections.Generic;

#nullable disable

namespace modelfor_archive.Models
{
    public partial class Attachment
    {
        public int AttachmentId { get; set; }
        public int? MessageId { get; set; }
        public string AttDesc { get; set; }
        public string AttFile { get; set; }  // photo

        public virtual Message Message { get; set; }
    }
}