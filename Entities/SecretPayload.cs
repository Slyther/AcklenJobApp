using System;

namespace AcklenAveApplication.Entities
{
    public class SecretPayload
    {
        public SecretPayload()
        {
            ReceivedDateTime = DateTime.UtcNow;
        }
        public long Id { get; set; }
        public DateTime ReceivedDateTime { get; set; }
        public string Secret { get; set; }
    }
}