using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Echo.VIID.JsonConverters
{
    public class DateTimeJsonConverter : JsonConverter<DateTime>
    {
        private const string _DEFAULT_DATETIME_FORMAT = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        protected readonly static Type _datetimeType = typeof(DateTime);

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


        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == _datetimeType;
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException($"Unexpected token parsing date. Expected String, got { reader.TokenType}.");
            }
            string dateText = reader.GetString();
            if (string.IsNullOrEmpty(dateText))
            {
                throw new JsonException($"Cannot convert null value to {reader.TokenType}.");
            }
            if (!string.IsNullOrEmpty(DateTimeFormat))
            {
                return DateTime.ParseExact(dateText, DateTimeFormat, Culture, DateTimeStyles);
            }
            else
            {
                return DateTime.Parse(dateText, Culture, DateTimeStyles);
            }
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            if ((DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                || (DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
            {
                value = value.ToUniversalTime();
            }
            var format = string.IsNullOrWhiteSpace(DateTimeFormat) ? _DEFAULT_DATETIME_FORMAT : DateTimeFormat;
            var text = value.ToString(format, Culture);
            writer.WriteStringValue(text);
        }
    }
}
