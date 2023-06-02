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

            var sendEmail = SendMail("sender@email.com", user.Email, "Your account has been activated");
            if (sendEmail == "Email sent")
            {
                return "User added succesfully";
            }

            return "Operation failed";
        }

        public string SendMail(string sender, string reciever, string emailContent)
        {
            if (sender != null && reciever != null && emailContent != null)
            {
                var validateEmail = ValidateEmail(reciever);
                if (!validateEmail)
                {
                    return "Invalid email";
                }

                return "Email sent";
            }
            return "Email sent not successful. Kindly try again later";
        }

        public bool ValidateEmail(string reciever)
        {
            if (!string.IsNullOrEmpty(reciever))
            {
                if (reciever.Contains("@"))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
