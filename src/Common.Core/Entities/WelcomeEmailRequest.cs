using System;


namespace eShop.Common.Core.Entities
{
    public class WelcomeEmailRequest
    {
        public string ToEmail { get; set; }
        public string UserName { get; set; }
    }
}
