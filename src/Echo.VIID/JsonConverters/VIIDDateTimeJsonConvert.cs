using System;
using System.Collections.Generic;
using System.Text;

namespace Echo.VIID.JsonConverters
{
    public class VIIDDateTimeJsonConvert : DateTimeJsonConverter
    {
        private const string _FORMAT = "yyyyMMddHHmmss";
        public VIIDDateTimeJsonConvert() : base(_FORMAT)
        {

        }
    }
}
