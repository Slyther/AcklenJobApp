using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcklenAveApplication.Models
{

    public class SecretPayloadRegisterModel
    {
        public string Secret { get; set; }
    }

    public class SecretPayloadDisplayModel
    {
        public DateTime ReceivedDateTime { get; set; }
        public string Secret { get; set; }
    }
}