
using System;

namespace WooSerialization
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    [System.Runtime.InteropServices.ComVisible(false)]

    public class UInt64StringConverter : StringConverter<UInt64>
    {
        public override bool TryConvert(string self, out UInt64 result)
        {
            return UInt64.TryParse(self, out result);
        }
    }

#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

}
