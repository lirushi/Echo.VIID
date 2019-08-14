using Echo.VIID.JsonConverters;
using Echo.VIID.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Xunit;
namespace Echo.VIID.Test
{
    public class DateTimeJsonConverterTest
    {
        SubImage _img;

        public DateTimeJsonConverterTest()
        {
            _img = new SubImage()
            {
                ShotTime = DateTime.Now
            };
        }

        [Fact]
        public void Serialize()
        {
            var jsonText = JsonSerializer.Serialize(_img);
            using (var doc = JsonDocument.Parse(jsonText))
            {
                foreach (var element in doc.RootElement.EnumerateObject())
                {
                    if (element.Name == "ShotTime")
                    {
                        Assert.Equal(element.Value.GetString(), _img.ShotTime.ToString(VIIDDateTimeJsonConvert._FORMAT));
                        return;
                    }
                }
            }
        }

        [Fact]
        public void Deserialize()
        {
            var d = DateTime.Now;
            var jsonText = $"{{\"ShotTime\":\"{d.ToString(VIIDDateTimeJsonConvert._FORMAT)}\"}}";
            var img = JsonSerializer.Deserialize<SubImage>(jsonText);
            Assert.Equal(d.ToString(), img.ShotTime.ToString());
        }
    }
}
