using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace IamProgrammer.Services
{
    public static class GravatarService
    {
        public static string GetGravatarUrlWithEmail(string email)
        {
            string hash, imageUrl;
            //email to lower case and trim 
            email = email.Trim().ToLower();
            // email to MD5 
            using (MD5 md5Hash = MD5.Create())
            {
                hash = Helper.GetMd5Hash(md5Hash, email);
            }
            //concat gravar Url + hash email
            imageUrl = "https://www.gravatar.com/avatar/" + hash;
            return imageUrl;
        }
    }
}