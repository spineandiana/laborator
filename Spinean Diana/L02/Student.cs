﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tema_2_Spinean.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Facultate { get; set; }

        public int An { get; set; }
    }
}