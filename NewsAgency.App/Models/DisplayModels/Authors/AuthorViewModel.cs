using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewsAgency.App.Models
{
    public class AuthorViewModel
    {
        [DisplayName("Author")]
        public string Username { get; set; }
    }
}