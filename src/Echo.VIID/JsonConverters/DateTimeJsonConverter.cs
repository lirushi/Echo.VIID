using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Echo.VIID.JsonConverters
{
    public class DateTimeJsonConverter : DateTimeJsonConverterBase<DateTime>
    {
        private const string _DEFAULT_DATETIME_FORMAT = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        public DateTimeJsonConverter()
        {

        }

        public DateTimeJsonConverter(string format)
        {
            DateTimeFormat = format;
        }

        /// <summary>
        /// Gets or sets the date time styles used when converting a date to and from JSON.
        /// </summary>
        /// <value>The date time styles used when converting a date to and from JSON.</value>
        public DateTimeStyles DateTimeStyles { get; set; }

        /// <summary>
        /// Gets or sets the date time format used when converting a date to and from JSON.
        /// </summary>
        /// <value>The date time format used when converting a date to and from JSON.</value>
        public string DateTimeFormat { get; set; }


        /// <summary>
        /// Gets or sets the culture used when converting a date to and from JSON.
        /// </summary>
        /// <value>The culture used when converting a date to and from JSON.</value>
        public CultureInfo Culture { get; set; } = CultureInfo.CurrentCulture;


        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            string text;
            if (value is DateTime dateTime)
            {
                if ((DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                    dateTime = dateTime.ToUniversalTime();
                }

                text = dateTime.ToString(
                    string.IsNullOrWhiteSpace(DateTimeFormat) ? _DEFAULT_DATETIME_FORMAT : DateTimeFormat
                    , Culture);
            }
#if HAVE_DATE_TIME_OFFSET
            else if (value is DateTimeOffset dateTimeOffset)
            {
                if ((DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                    dateTimeOffset = dateTimeOffset.ToUniversalTime();
                }

                text = dateTimeOffset.ToString(
                    string.IsNullOrWhiteSpace(DateTimeFormat) ? _DEFAULT_DATETIME_FORMAT : DateTimeFormat
                    , Culture);
            }
#endif
            else
            {
                throw new JsonException($"Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {CultureInfo.InvariantCulture}.");
            }
            writer.WriteStringValue(text);
        }
    }
}
