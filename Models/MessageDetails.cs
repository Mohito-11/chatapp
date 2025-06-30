using System;
using System.Collections.Generic;
using System;

namespace ChatApp.Models
{
    public class MessageDetails
    {
        public string MessageId { get; set; }
        public string Message { get; set; }
        public string To { get; set; }
        public string MessageTime { get; set; }
        public string From { get; set; }
        public bool IsEdited { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public bool IsFile { get; set; } = false;
        public string FileName { get; set; }
        public string IsForwarded { get; set; }
        public string ForwardedTo { get; set; }
        public string IsReplied { get; set; }
        public string RepliedTo { get; set; }
        public string ReplySender { get; set; }
        public string RepliedText { get; set; }
        public ReplyTo replyTo { get; set; }
    }

    public class ReplyTo
    {
        public string messageId { get; set; }
        public string sender { get; set; }
        
        public string message { get; set; }
    }

    public class EditMessageRequest
    {
        public string MessageId { get; set; }
        public string NewMessage { get; set; }
        public string GroupName { get; set; }
    }


    public class DeleteMessageRequest
    {
        public string MessageId { get; set; }
        public string GroupName { get; set; }
    }

}
