using System;
using System.Collections.Generic;
using System.Text;

namespace CleverSharp.Models
{
    public class CleverData<T>
    {
        public T Data { get; set; }

        public List<Link> Links {get; set;}

        public Paging Paging { get; set; }
    }
}
