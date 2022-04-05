using System;
using System.Collections.Generic;
using schema = Schema.NET;

namespace WEB_1001_JSON_LD_Example.Models
{
    public class Blog
    {
        public string Name { get; set; }
        public Uri Url { get; set; }
        public string Description { get; set; }

        public schema.Thing GetJson()
        {
            schema.Blog blog = new schema.Blog();

            blog.About = new schema.OneOrMany<schema.IThing>(new List<schema.Thing>() { new schema.Thing() { Name = this.Description } }) ;
            blog.Url = this.Url;
            blog.Name = this.Name;

            return blog;
        }
    }
}
