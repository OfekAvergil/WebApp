﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Contact
    {
        public int Id {get; set; }

        [Required]
        public string Name { get; set; }

        public List<Message> Msgs { get; set; }


    }
}
