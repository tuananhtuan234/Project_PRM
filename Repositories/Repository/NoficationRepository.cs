using Microsoft.EntityFrameworkCore;
using Repositories.Data;
using Repositories.Data.Entity;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class NoficationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _context;

        public NoficationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetAllNotification(string userId)
        {
            return await _context.Notifications.OrderByDescending(sc => sc.CreatedAt).Where(sc => sc.UserId.Equals(userId)).ToListAsync();
        }

        public async Task<Notification> GetNotificationById(string id)
        {
            return await _context.Notifications.FirstOrDefaultAsync(sc => sc.Id.Equals(id));
        }

        public async Task<bool> AddNotification(Notification notification)
        {
            _context.Notifications.Add(notification);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateNotification(Notification notification)
        {
            _context.Notifications.Update(notification);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task DeleteNotification(string id)
        {
            var notification = await GetNotificationById(id);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                await _context.SaveChangesAsync();
            }
        }
    }
}
