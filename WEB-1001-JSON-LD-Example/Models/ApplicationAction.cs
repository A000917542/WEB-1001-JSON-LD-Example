using System;
using schema = Schema.NET;

namespace WEB_1001_JSON_LD_Example.Models
{
    public class ApplicationAction
    {
        public string Name { get; set; }

        public Uri Url { get; set; }

        public schema.Thing GetJson()
        {
            schema.Action action = new schema.Action();

            action.Name = Name;
            // action.Url = Url;

            action.Target = Url;

            return action;
        }
    }
}
