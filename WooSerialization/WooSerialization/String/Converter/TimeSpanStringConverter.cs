
using System;

namespace WooSerialization
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TimeSpanStringConverter : StringConverter<TimeSpan>
    {
        public override bool TryConvert(string self, out TimeSpan result)
        {
            return TimeSpan.TryParse(self, out result);
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}