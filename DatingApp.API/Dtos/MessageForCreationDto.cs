using System;

namespace DatingApp.API.Dtos
{
    public class MessageForCreationDto
    {
        public MessageForCreationDto(int id, int senderId, string senderKnownAs, string senderPhotoUrl, int recipientId, string recipientKnownAs, string recipientPhotoUrl, string content, bool isRead, DateTime messageSent) 
        {
            this.Id = id;
                this.SenderId = senderId;
                this.SenderKnownAs = senderKnownAs;
                this.SenderPhotoUrl = senderPhotoUrl;
                this.RecipientId = recipientId;
                this.RecipientKnownAs = recipientKnownAs;
                this.RecipientPhotoUrl = recipientPhotoUrl;
                this.Content = content;
                this.IsRead = isRead;
                this.MessageSent = messageSent;
               
        }
                public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderKnownAs { get; set; }
        public string SenderPhotoUrl { get; set; }
        public int RecipientId { get; set; }
        public string RecipientKnownAs { get; set; }
        public string RecipientPhotoUrl { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; }
    }
}