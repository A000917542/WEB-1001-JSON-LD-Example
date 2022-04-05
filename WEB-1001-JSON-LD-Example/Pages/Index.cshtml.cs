using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using schema = Schema.NET;
using local = WEB_1001_JSON_LD_Example.Models;

namespace WEB_1001_JSON_LD_Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ICollection<schema.Thing> JSONLD {
        get {
                List<schema.Thing> lst = new List<schema.Thing>() { Blog.GetJson() };
                foreach (var action in Actions)
                {
                    lst.Add(action.GetJson()) ;
                }
                
                return lst;
            }
        }

        public local.Blog Blog { get; set; } = new local.Blog();

        private ICollection<local.ApplicationAction> Actions { get; set; } = new List<local.ApplicationAction>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Blog.Description = "Description";
            Blog.Name = "Test Blog";
            Blog.Url = new Uri($"https://example.com/");

            Actions.Add(new local.ApplicationAction() { Name = "Edit", Url = new Uri(@"https://example.com/Blog/Edit") });
            Actions.Add(new local.ApplicationAction() { Name = "Add", Url = new Uri(@"https://example.com/Blog/New") });
        }

        public void OnGet()
        {
        }
    }
}
