using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{
    

    public class School_Admins : CleverRequestDocument
    {
        public string District { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
        public List<string> Schools { get; set; }
        public string Staff_Id { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
    }

   

   




}
