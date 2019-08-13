using System;
using System.Collections.Generic;
using System.Text;

namespace Echo.VIID.JsonConverters
{
    /// <summary>
    /// <see cref="DateTime"/> 或 <see cref="DateTimeOffset"/> 转换为JSON的基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class DateTimeJsonConverterBase<T> : NullableJsonConverter<T> where T : struct
    {
        protected readonly static Type _datetimeType = typeof(DateTime);
        protected readonly static Type _dateTimeOffsetType = typeof(DateTimeOffset);


        public override bool CanConvert(Type typeToConvert)
        {
            Type targetType = IsNullableType ? Nullable.GetUnderlyingType(typeToConvert) : typeToConvert;
            return targetType != _datetimeType;
#if HAVE_DATE_TIME_OFFSET
            return targetType != _dateTimeOffsetType;
#endif
        }
    }
}
