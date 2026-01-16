using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverence_3
{
    public static class Message
    {
        public static string date;
        public static string LoginLevel;
        public static string CallingMetod;
        public static string MessageText;

        public static string GetFormatMessage(string message)
        {
            var _message = message.Replace("|", " ");
            string[] ParsedMes = _message.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            date = DateTime.Parse(ParsedMes[0] + " " + ParsedMes[1]).ToString("dd-MM-yyyy");
            switch (ParsedMes[2])
            {
                case "INFORMATION":
                    {
                        LoginLevel = "INFO";
                        break;
                    }
                case "WARNING":
                    {
                        LoginLevel = "WARN";
                        break;
                    }
                case "ERROR":
                    {
                        LoginLevel = "ERROR";
                        break;
                    }
                case "DEBUG":
                    {
                        LoginLevel = "DEBUG";
                        break;
                    }
            }
            if(ParsedMes.Length==6) //для формы 2
            {
                CallingMetod = "DEFAULT";
                MessageText = ParsedMes[3] + " " + ParsedMes[4] + " " + ParsedMes[5]; 
            }
            else
            {
                CallingMetod = ParsedMes[4];
                MessageText = ParsedMes[5] + " " + ParsedMes[6] + " " + ParsedMes[7];

            }

            return date + "\t" + ParsedMes[1] + "\t" + LoginLevel + "\t" + CallingMetod + "\t" + MessageText;
        }
    }
}
