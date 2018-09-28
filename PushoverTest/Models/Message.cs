using System;
namespace PushoverTest.Models
{
    /// <summary>
    /// Модель сообщения Pushover для WebAPI
    /// </summary>
    public class Message
    {
        public string token { get; set; }
        public string user { get; set; }
        public string message { get; set; }
    }
}
