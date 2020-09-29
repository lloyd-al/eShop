using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace eShop.Common.Core.Entities
{
    public class EmailRequest
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
