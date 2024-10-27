using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Data.DTOs.Notification;
using Services.Interface;
using System.ComponentModel.DataAnnotations;

namespace Micracle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationServices _notificationServices;

        public NotificationController(INotificationServices notificationServices)
        {
            _notificationServices = notificationServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([Required] string userId)
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationServices.GetAllNotification(userId);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetNotificationById([Required] string Id)
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationServices.GetNotificationById(Id);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddNotificationDtos addNotificationDtos)
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationServices.AddNotification(addNotificationDtos);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update( [Required] string Id, [FromBody] UpdateNotificationDtos updateNotificationDtos )
        {
            if (ModelState.IsValid)
            {
                var result = await _notificationServices.UpdateNotification(Id, updateNotificationDtos);
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete( [Required] string id)
        {
            if (ModelState.IsValid)
            {
               await _notificationServices.DeleteNotification(id);
                return Ok("Delete Success");    
            }
            return BadRequest();
        }
    }
}
