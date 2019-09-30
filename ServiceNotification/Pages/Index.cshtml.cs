using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceNotification.Models;

namespace ServiceNotification.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext dbContext;
        private readonly ILogger<IndexModel> _logger;

        public List<User> UserList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContex)
        {
            _logger = logger;
            this.dbContext = dbContex;
        }

        public void OnGet()
        {
            _logger.LogInformation("Home page requested");

            UserList = dbContext.User.ToList<User>();
        }
    }
}
