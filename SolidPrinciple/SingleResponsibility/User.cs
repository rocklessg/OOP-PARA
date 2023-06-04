using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.SingleResponsibility
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AddUser(int id, string email)
        {
            var user = new User
            {
                Id = id,
                Name = "Abdulhafiz",
                Email = email,
                Password = $"{Name}{new Random().Next(1111, 9999)}"
            };

            var sendEmail = new EmailSend();
            var result = sendEmail.SendMail("sender@email.com", user.Email, "Your account has been activated");
            if (result == "Email sent")
            {
                return "User added succesfully";
            }

            return "Operation failed";
        }
    }
}
