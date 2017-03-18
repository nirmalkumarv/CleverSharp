using Newtonsoft.Json;
using System.Collections.Generic;

namespace CleverSharp
{
    public class GetResult<T> where T : ICleverRequestDocument, new()
        {
            public bool IsError { get; set; }

        public string error { get; set; }
        public T Data { get; set; }


    }


}
