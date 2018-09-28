using System;
using System.Net.Http;
using System.Collections.Specialized;
using PushoverTest.Models;
using Newtonsoft.Json;
using System.Text;

namespace PushoverTest
{
    public static class Misc
    {
        /// <summary>
        /// Отправка сообщения в PushoverAPI
        /// </summary>
        /// <param name="message">Модель сообшения</param>
        public static void SendToPushover (Message message)
        {
            var parameters = new ListDictionary {
                { "token", message.token },
                { "user", message.user },
                { "message", message.message }
            };

            using (var client = new HttpClient())
            {
                string url = "https://api.pushover.net/1/messages.json";
                string jsonObject = JsonConvert.SerializeObject(parameters);

                var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                var result = client.PostAsync(url, content).Result;
            }
        }
    }
}
