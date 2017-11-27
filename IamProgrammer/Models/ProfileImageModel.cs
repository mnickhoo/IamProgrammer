using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IamProgrammer.Models
{
    public class ProfileImageModel
    {
        public string version { get; set; }
        public string encoding { get; set; }
        public Entry entry { get; set; }
    }



    public class Entry
    {
        public string xmlns { get; set; }
        public string xmlnsgphoto { get; set; }
        public Id id { get; set; }
        public Published published { get; set; }
        public Updated updated { get; set; }
        public Category[] category { get; set; }
        public Title title { get; set; }
        public Summary summary { get; set; }
        public Link[] link { get; set; }
        public Author[] author { get; set; }
        [JsonProperty("gphoto$user")]
        public GphotoUser gphotouser { get; set; }
        [JsonProperty("gphoto$nickname")]
        public GphotoNickname gphotonickname { get; set; }
        [JsonProperty("gphoto$thumbnail")]
        public GphotoThumbnail gphotothumbnail { get; set; }
    }

    public class Id
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }

    public class Published
    {
        [JsonProperty("$t")]
        public DateTime t { get; set; }
    }

    public class Updated
    {
        [JsonProperty("$t")]
        public DateTime t { get; set; }
    }

    public class Title
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
    }

    public class Summary
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
    }

    public class GphotoUser
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }

    public class GphotoNickname
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class GphotoThumbnail
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }

    public class Category
    {
        public string scheme { get; set; }
        public string term { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Author
    {
        public Name name { get; set; }
        public Uri uri { get; set; }
    }

    public class Name
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }

    public class Uri
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }

}