﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationToo.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}