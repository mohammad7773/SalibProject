using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace SalibProject
{
    public class Account
    {

        private string firstname;
        private string lastname;
        private string password;
        private string nationalcode;
        private string mobile;
        private string email;
        public Account(string firstname, string lastname, string password, string nationalCode, string mobile, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.password = password;
            this.nationalcode = nationalCode;
            this.mobile = mobile;
            this.email = email;
            UserNameMethod(firstname, lastname);
            PasswordMethod(password);
            NationalCodeMethod(nationalcode);
            MobileMethod(mobile);
            EmailMethod(email);
            WellCome();
        }


        public Account()
        {

        }

        //End Account constracture
        public string FirstName
        {
            set
            {
                firstname = value;

            }
            get
            {
                return firstname;
            }
        }
        public string LastName
        {
            set
            {
                lastname = value;

            }
            get
            {
                return lastname;
            }
        }
        public string Password
        {
            set
            {
                password = value;

            }
            get
            {
                return password;
            }
        }
        public string NationalCode
        {
            set
            {
                nationalcode = value;

            }
            get
            {
                return nationalcode;
            }
        }
        public string Mobile
        {
            set
            {
                mobile = value;

            }
            get
            {
                return mobile;
            }
        }
        public string Email
        {
            set
            {
                email = value;

            }
            get
            {
                return email;
            }
        }
        List<string> NameList = new List<string>(); 
        List<string> PassSaveList = new List<string>();

        #region Method
        public string UserNameMethod(string firstname, string lastname)
        {
            var username = firstname + lastname;
            if (username.Contains("_"))
            {
                Console.WriteLine("OoOops UserName is not Valid!!!");
            }
            else
            {
                if (!Regex.IsMatch(username, "^[a-zA-Z0-9]*$"))
                {
                    Console.WriteLine("Please insert English Character");
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(firstname) && !string.IsNullOrWhiteSpace(lastname))
                    {
                        Console.WriteLine("UserName" + " " + firstname + "_" + lastname);
                    }
                    else
                    {
                        Console.WriteLine("Inputes IS Empty");
                    }
                }
            }
            NameList.Add(username);
            return username;
        }

        public void PasswordMethod(string password)
        {
            var pass = Regex.Replace(password, ".{1}", "$0.");
            var Spassword = pass.Split(".").ToArray();
            if (!char.IsUpper(Convert.ToChar(Spassword[0])) &&
                !char.IsLower(Convert.ToChar(Spassword[1])) &&
                password.Any(char.IsDigit))
            {
                Console.WriteLine("password is incorrect" + "(" + "Corect format for password is Upper char and Lower char and digitnum" + ")");
            }
            else
            {
                Console.WriteLine("Password Save");
                PassSaveList.Add(password);
            }

        }

        public void NationalCodeMethod(string nationalcode)
        {
            if (nationalcode.Length > 10)
            {
                Console.WriteLine("The Code is more then 10");
            }
            else
            {
                var code = Regex.Replace(nationalcode, ".{1}", "$0.");
                var code1 = code.Split(".").ToList();
                var sum = new int();
                for (int i = 0; i < code1.Count - 1; i++)
                {
                    Console.WriteLine(Convert.ToInt32(code1[i]) * (i + 1));
                    sum += Convert.ToInt32(code1[i]) * (i + 1);
                }
                Console.WriteLine("Sum of CodeNumber");
                Console.WriteLine(sum);
            }
        }

        public void MobileMethod(string mobile)
        {
            if (mobile.StartsWith("+98") && mobile.Length == 13)
            {
                var num = mobile.Replace("+98", "0");
                Console.WriteLine(num + " " + "Mobile Saved!");

            }
            else
            {
                if (mobile.StartsWith("09") && mobile.Length == 11)
                {
                    Console.WriteLine("Mobile Saved!");
                }
                else
                {
                    Console.WriteLine(mobile + " " + "mobile is not valid!!!!!!");
                }
            }
        }

        public void EmailMethod(string email)
        {
            var emsplit = email.Split("@").ToArray();

            for (int i = 0; i < emsplit.Length - 1; i++)
            {
                var emsp = emsplit[1].Split(".");

                if (emsp[1].Length <= 5)
                {
                    Console.WriteLine("Email Saved!");
                }
            }
        }

        public void WellCome()
        {
            foreach (var V in NameList)
            {
                var replace = V.Replace("_", "");
                var newname = replace.First().ToString().ToUpper() + replace.Substring(1);
                Console.WriteLine("WellCome" + " " + newname);
            }
        }

       
        }
        #endregion
    }   

  


