﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Client
    {
        public int Id { set; get; }
        [Required]
        public string ClientFIO { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }
        public List<Order> Orders { get; set; }
    }
}
