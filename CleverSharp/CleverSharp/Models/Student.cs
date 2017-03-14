using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{
    

        public class Student
    {
            public DateTime Created { get; set; }
            public Credentials Credentials { get; set; }
            public string District { get; set; }
            public string Dob { get; set; }
            public string Ell_Status { get; set; }
            public string Email { get; set; }
            public string Frl_Status { get; set; }
            public string Gender { get; set; }
            public string Grade { get; set; }
            public string Hispanic_Ethnicity { get; set; }
            public string Iep_Status { get; set; }
            public DateTime Last_Modified { get; set; }
            public Location Location { get; set; }
            public Name Name { get; set; }
            public string Race { get; set; }
            public string School { get; set; }
            public string Sis_Id { get; set; }
            public string State_Id { get; set; }
            public string Student_Number { get; set; }
            public string Id { get; set; }
        }

        public class Credentials
        {
            public string District_username { get; set; }
        }

       

       

       

    }

