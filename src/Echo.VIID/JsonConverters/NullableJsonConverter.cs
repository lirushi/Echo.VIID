using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Echo.VIID.JsonConverters
{
    public abstract class NullableJsonConverter<T> : JsonConverter<T> where T : struct
    {
        protected readonly static Type _nullableType = typeof(Nullable<>);

        protected bool IsNullableType
        {
            get
            {
                var type = typeof(T);
                return type.IsGenericType && type.GetGenericTypeDefinition() == _nullableType;
            }
        }
    }
}
