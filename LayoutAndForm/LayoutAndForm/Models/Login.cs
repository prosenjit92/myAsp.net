﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutAndForm.Models
{
    public class Login
    {
        public string name { get; set;}
        public string id { get; set;}
        public string gender { get; set;}
        public string profession { get; set;}
        public string[] hobbies { get; set;}
    }
}