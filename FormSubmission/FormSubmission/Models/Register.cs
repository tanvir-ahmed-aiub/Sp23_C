﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Please provide name")]
        [StringLength(10,ErrorMessage ="Name should not exceed 10 chars")]
        public string Name { get; set; }
        [Required]
        public string Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        public DateTime Dob { get; set; }
    }
}