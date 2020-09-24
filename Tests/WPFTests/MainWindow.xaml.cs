using System;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace WPFTests
{
    public partial class MainWindow
    {
        public MainWindow() => InitializeComponent();

        private void OnSendButtonClick(object sender, RoutedEventArgs e)
        {
            var from = new MailAddress("pns95@mail.ru", "Ника");
            var to = new MailAddress("pns9595@mail.ru", "ник");
            

            var message = new MailMessage(from, to);

            message.Subject = "Заголовок письма от " + DateTime.Now;
            message.Body = "Текст тестового письма + " + DateTime.Now;

            var client = new SmtpClient("smtp.mail.ru", 25);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential
            {
                UserName = LoginEdit.Text,
                SecurePassword = PasswordEdit.SecurePassword
            };

            client.Send(message);

        }
    }
}
