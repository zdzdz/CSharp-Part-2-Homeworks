//Problem 18. Extract e-mails

//    Write a program for extracting all email addresses from given text.
//    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ExtractEmails
{
    class emails
    {
        static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };
        static readonly char[] trimmers = new char[] { '.', '-', '/', '\\' };
        static void Main(string[] args)
        {
            string sample = "Hi! My email @ yahoo is myemail@yahoo.com. I also have 101mailGO@mail_provider.co.uk! You can write me to my work-email too:work_mail@privider.at.my.work";
            string[] input = sample
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => EmailIsValid(x.Trim(trimmers)))
            .ToArray();
            Console.WriteLine(Environment.NewLine + GetEMails(input));
        }
        private static string GetEMails(string[] input)
        {
            StringBuilder result = new StringBuilder();
            foreach (var email in input)
            {
                result.AppendLine(email.Trim(trimmers));
            }
            if (result.Length == 0)
                result.AppendLine("No emails found!");
            return result.ToString();
        }
        static bool EmailIsValid(string email)
        {
            try
            {
                MailAddress address = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
