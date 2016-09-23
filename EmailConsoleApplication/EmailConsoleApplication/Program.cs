using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = new EmailValidater();


            var list = new List<string>();

            #region Valid
            list.Add(String.Format("email@domain.com"));
            list.Add(String.Format("firstname.lastname@domain.com"));
            list.Add(String.Format("email@subdomain.domain.com"));
            list.Add(String.Format("firstname+lastname@domain.com"));
            list.Add(String.Format("email@123.123.123.123"));
            list.Add(String.Format("email@[123.123.123.123]"));
            list.Add(String.Format("“email”@domain.com"));
            list.Add(String.Format("1234567890@domain.com"));
            list.Add(String.Format("email@domain-one.com"));
            list.Add(String.Format("_______@domain.com"));
            list.Add(String.Format("email@domain.name"));
            list.Add(String.Format("email@domain.co.jp"));
            list.Add(String.Format("firstname-lastname@domain.com")); 
            #endregion


            //list.Add(String.Format(""));
            //list.Add(String.Format(""));
            //list.Add(String.Format(""));


            foreach (var email in list)
            {
                Console.WriteLine(result.String_IsEmailAddressValid(email));
            }
            Console.ReadLine();
        }
    }
}
