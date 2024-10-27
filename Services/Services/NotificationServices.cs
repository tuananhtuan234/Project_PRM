using Repositories.Data.DTOs.Notification;
using Repositories.Data.Entity;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class NotificationServices : INotificationServices
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationServices(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<string> AddNotification(AddNotificationDtos notificationDtos)
        {
            if (notificationDtos == null)
            {
                return "Data is null";
            }
            var notification = new Notification()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = notificationDtos.UserId,
                Message = notificationDtos.Message,
                IsRead = true,
                CreatedAt = DateTime.Now,
            };
            var result = await _notificationRepository.AddNotification(notification);
            return result ? "Add Success" : "Add Failed";
        }

        public async Task DeleteNotification(string id)
        {
            await _notificationRepository.DeleteNotification(id);
        }

        public async Task<List<Notification>> GetAllNotification(string userId)
        {
            return await _notificationRepository.GetAllNotification(userId);
        }

        public async Task<Notification> GetNotificationById(string id)
        {
            return await _notificationRepository.GetNotificationById(id);
        }

        public async Task<string> UpdateNotification(string id, UpdateNotificationDtos notificationDtos)
        {
            var existingNotification = await _notificationRepository.GetNotificationById(id);
            if (existingNotification == null)
            {
                return "Notification is not found";
            }
            existingNotification.Message = notificationDtos.Message;
            existingNotification.IsRead = notificationDtos.IsRead;

            var result = await _notificationRepository.UpdateNotification(existingNotification);
            return result ? "Update Success" : "Update Failed";
        }
    }
}
