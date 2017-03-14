using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{

    public class School
    {
        public DateTime Created { get; set; }
        public string District { get; set; }
        public string High_grade { get; set; }
        public DateTime Last_modified { get; set; }
        public Location Location { get; set; }
        public string Low_grade { get; set; }
        public string Name { get; set; }
        public string Nces_id { get; set; }
        public string Phone { get; set; }
        public Principal Principal { get; set; }
        public string School_number { get; set; }
        public string Sis_Id { get; set; }
        public string State_Id { get; set; }
        public string Id { get; set; }
    }

   

    public class Principal
    {
        public string name { get; set; }
        public string email { get; set; }
    }

   


}
