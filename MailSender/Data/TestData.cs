using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WpfMailSender.Models;


namespace WpfMailSender.Data
{
    class TestData
    {
        public static IList<Server> Servers { get; } = new List<Server>
        {
            new Server
            {
                Id = 1,
                Name = "Яндекс",
                Address = "smpt.yandex.ru",
                Port = 587,
                UseSSL = true,
                Login = "user@yandex.ru",
                Password = "PassWord",
            },
            new Server
            {
                Id = 2,
                Name = "gMail",
                Address = "smpt.gmail.com",
                Port = 465,
                UseSSL = true,
                Login = "user@gmail.com",
                Password = "PassWord",
            }//,
        };

        public static IList<Sender> Senders { get; } = new List<Sender>
        {
            new Sender
            {
                Id = 1,
                Name = "Пупкин",
                Address = "pupkin@server.ru",
                Description = "Почта от Пупкина"
            },
            new Sender
            {
                Id = 2,
                Name = "Владимиров",
                Address = "vlad@server.ru",
                Description = "Почта от Владимирова"
            },
            new Sender
            {
                Id = 3,
                Name = "Распутин",
                Address = "rasputin@server.ru",
                Description = "Почта от Распутина"
            }//,

        };

        public static IList<Recipient> Recipients { get; } = new List<Recipient>
        {
            new Recipient
            {
                Id = 1,
                Name = "Пупкин",
                Address = "pupkin@server.ru",
                Description = "Почта для Пупкина"
            },
            new Recipient
            {
                Id = 2,
                Name = "Владимиров",
                Address = "vlad@server.ru",
                Description = "Почта для Владимирова"
            },
            new Recipient
            {
                Id = 3,
                Name = "Распутин",
                Address = "rasputin@server.ru",
                Description = "Почта для Распутина"
            }//,
        };

        public static IList<Message> Messages { get; } = Enumerable
            .Range(1, 10)
            .Select(i => new Message
            {
                Id = i,
                Tittle = $"Сообщение {i}",
                Body = $"Текст сообщения {i}"
            })
            .ToList();
    }
}
