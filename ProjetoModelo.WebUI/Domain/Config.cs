﻿using System.Web.Configuration;

namespace ProjetoModelo.WebUI.Domain
{
    public class Config
    {
        public static string AccountSid => WebConfigurationManager.AppSettings["AccountSid"] ??
                                          "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        public static string AuthToken => WebConfigurationManager.AppSettings["AuthToken"] ??
                                          "aXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        public static string TwilioNumber => WebConfigurationManager.AppSettings["TwilioNumber"] ??
                                             "+123456";
    }
}