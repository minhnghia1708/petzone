using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shop.code
{
    public class LoginModel
    {

        public string UserName { get; set; }
        [Required]
        public string password { get; set; }

        public bool RememberMe { get; set; }



    }
}