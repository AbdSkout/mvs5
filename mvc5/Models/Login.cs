using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc5.Models
{
    public class Login
    {
        [Key, Column(Order = 0)]
        [Required( ErrorMessage = "user name is  Required")]

        public string user_name { set; get; }
        
        [Required(ErrorMessage = "password is  Required")]
        
        public string password { set; get; }

        public int type { get; set; }


    }






}