using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlinBarwoodSite_Term3.Models
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }
        public User? Sender { get; set; }
        public User? Recipient { get; set; }
        public string? Subject { get; set; }
        public int Priority { get; set; }
        public string? MsgBody { get; set; }
        public DateTime SendDate { get; set; }
    }
}
