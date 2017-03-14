using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{    


    public class Paging
    {
        public int Current { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
    }

    public class StudentContact
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Phone_type { get; set; }
        public string Relationship { get; set; }
        public string Student { get; set; }
        public string Id { get; set; }
    }
        

}
