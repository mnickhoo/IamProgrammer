using IamProgrammer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace IamProgrammer.Services
{
    public class ProfileImageService
    {
        public async Task<ProfileImageModel> GetProfile(string email)
        {
            string _url = "http://picasaweb.google.com/data/entry/api/user/" + email + "?alt=json";
            HttpResponseMessage response;
            ProfileImageModel profile = new ProfileImageModel();
            using (var client = new HttpClient())
            {
                response = await client.GetAsync(_url);
                if (response.IsSuccessStatusCode)
                {
                    var stringifyResponse = await response.Content.ReadAsStringAsync();//Serialize response
                    profile = JsonConvert.DeserializeObject<ProfileImageModel>(stringifyResponse); //deserialise to profileImageModel
                }
            }
            return profile;
        }
        public async Task<string> GetUrlProfileImage(string email)
        {
            //return a json format 
            var profile = await GetProfile(email);
            return profile.entry.gphotothumbnail.t;
        }
    }
}