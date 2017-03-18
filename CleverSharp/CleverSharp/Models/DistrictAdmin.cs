using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{
   

    public class District_Admins : CleverRequestDocument
    {
        public string Id { get; set; }
        public string District { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
    }

    

   

}
