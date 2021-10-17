using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tema_2_Spinean.Models;

namespace tema_2_Spinean.Repositories
{
    public static class StudentsRepo
    {
        public static List<Student> Student = new List<Student>(){
            new Student { Id = 1; Nume = Spinean; Prenume = Diana ;Facultate = AC; An =4; },
            new Student { Id = 2; Nume = Chis; Prenume = Denisa ;Facultate = AC; An =1; }
        };
    }
}