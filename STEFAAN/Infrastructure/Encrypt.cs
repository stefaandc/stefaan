﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STEFAAN.Infrastructure
{
    public static class Encrypt
    {
        
        public static string EncryptPassword(string txtPassword)
        {
            byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(txtPassword);
            string encryptPassword = Convert.ToBase64String(passBytes);
            return encryptPassword;
        }


        
        public static string DecryptPassword(string encryptedPassword)
        {
            byte[] passByteData = Convert.FromBase64String(encryptedPassword);
            string originalPassword = System.Text.Encoding.Unicode.GetString(passByteData);
            return originalPassword;
        }
    }
}