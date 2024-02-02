﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlinBarwoodSite_Term2.Models
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }
        public AppUser? Sender { get; set; }
        public AppUser? Recipient { get; set; }
        public string? Subject { get; set; }
        public int Priority { get; set; }
        public string? MsgBody { get; set; }
        public DateTime SendDate { get; set; }
    }
}
