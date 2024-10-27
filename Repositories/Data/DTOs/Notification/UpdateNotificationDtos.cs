using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Data.DTOs.Notification
{
    public class UpdateNotificationDtos
    {       
        public string Message { get; set; }
        public bool IsRead { get; set; }      
    }
}
