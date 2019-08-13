using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;

namespace Echo.VIID.Models
{
    public class RootObject<T>
    {
        [JsonPropertyName("")]
        public T Sub { get; set; }
    }
}
