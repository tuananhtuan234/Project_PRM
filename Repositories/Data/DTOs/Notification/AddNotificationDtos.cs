using Repositories.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Data.DTOs.Notification
{
    public class AddNotificationDtos
    {
        public string UserId { get; set; }
        public string Message { get; set; }
    }
}
