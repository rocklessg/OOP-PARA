using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple.SingleResponsibility
{
    public class EmailSend
    {
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
