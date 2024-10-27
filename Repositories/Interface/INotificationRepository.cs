using Repositories.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface INotificationRepository
    {
        Task<List<Notification>> GetAllNotification(string userId);
        Task<Notification> GetNotificationById(string id);
        Task<bool> AddNotification(Notification notification);
        Task<bool> UpdateNotification(Notification notification);
        Task DeleteNotification(string id);
    }
}
