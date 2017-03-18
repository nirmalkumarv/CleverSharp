using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{

    public class Sections : CleverRequestDocument
    {
        public string Course_Name { get; set; }
        public string Course_Number { get; set; }
        public DateTime Created { get; set; }
        public string District { get; set; }
        public string Grade { get; set; }
        public DateTime Last_Modified { get; set; }
        public string Name { get; set; }
        public string Period { get; set; }
        public string School { get; set; }
        public string Sis_Id { get; set; }
        public List<string> Students { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public List<string> Teachers { get; set; }
        public Term Term { get; set; }
        public string Id { get; set; }
    }

    public class Term
    {
        public string End_Date { get; set; }
        public string Name { get; set; }
        public string Start_Date { get; set; }
    }

   

}
