using Repositories.Data.DTOs.Notification;
using Repositories.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface INotificationServices
    {
        Task<List<Notification>> GetAllNotification(string userId);
        Task<Notification> GetNotificationById(string id);
        Task<string> UpdateNotification(string id, UpdateNotificationDtos notificationDtos);
        Task<string> AddNotification(AddNotificationDtos notificationDtos);
        Task DeleteNotification(string id);
    }
}
