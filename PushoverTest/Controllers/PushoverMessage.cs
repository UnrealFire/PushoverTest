using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PushoverTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PushoverTest.Controllers
{
    [Route("api/[controller]")]
    public class PushoverMessage : Controller
    {
        /// <summary>
        /// Прием сообщения для Pushover
        /// </summary>
        /// <param name="message">Модель сообщения</param>
        [HttpPost]
        public IActionResult Post([FromBody]Message message)
        {
            if (message == null)
            {
                return BadRequest();
            }

            //метод отправки сообщения в Pushover
            Misc.SendToPushover(message);

            return Ok(message);
        }
    }
}
