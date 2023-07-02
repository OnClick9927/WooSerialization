
namespace WooSerialization
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SByteStringConverter : StringConverter<sbyte>
    {
        public override bool TryConvert(string self, out sbyte result)
        {
            return sbyte.TryParse(self, out result);
        }
    }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
}